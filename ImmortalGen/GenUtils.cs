using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
	public class GenUtils
	{
		public const string GenDataPath = "GenData";
		public const string DefsCodePath = "ImmortalDefs";
		public static string SolutionDir { get; } = EnvUtils.GetSolutionDir();

		private static readonly string[] EmptyLine = new[] { "" };

		public static string GetGenDataPath(string filePath)
		{
			return Path.Combine(SolutionDir, GenDataPath, filePath);
		}

		public static string GetDefCodePath(string filePath)
		{
			return Path.Combine(SolutionDir, DefsCodePath, filePath);
		}

		public static List<string>? GetGenData(string filePath)
		{
			var fullPath = GenUtils.GetGenDataPath(filePath);

			if (!File.Exists(fullPath))
			{
				$"Missing input file: {fullPath}".qwe();
				return null;
			}


			var lines = File.ReadAllLines(fullPath)
				.Select(x => x.TrimEnd())
				.ToList();

			return lines;
		}

		public static bool TryAddComment(string inputLine, List<string> output)
		{
			if (inputLine.StartsWith("#"))
			{
				if (output.Count != 0) output.Add("");
				output.Add($"// {inputLine.TrimStart('#').Trim()}");
				return true;
			}
			return false;
		}

		/// <summary>
		/// Replaces block between "// <{identifier}Gen:Start>" and "// <{identifier}Gen:End>"
		/// with newLines, maintaining original indentation.
		/// </summary>
		public static void ReplaceCode(string filePath, string identifier, List<string> newLines)
		{
			if (!File.Exists(filePath))
			{
				$"Missing target file: {filePath}".qwe();
				return;
			}

			var startMarker = $"// <{identifier}Gen:Start>";
			var endMarker = $"// <{identifier}Gen:End>";

			var lines = File.ReadAllLines(filePath).ToList();
			int startIndex = -1, endIndex = -1;
			string indent = "";

			for (int i = 0; i < lines.Count; i++)
			{
				var l = lines[i];
				if (startIndex < 0 && l.Contains(startMarker))
				{
					startIndex = i;
					indent = new string(l.TakeWhile(Char.IsWhiteSpace).ToArray());
				}
				else if (startIndex >= 0 && l.Contains(endMarker))
				{
					endIndex = i;
					break;
				}
			}

			if (startIndex < 0 || endIndex < 0 || endIndex <= startIndex)
			{
				$"Invalid generator target file: {filePath}".qwe();
				return;
			}

			// Compose indented block
			var indented = newLines.Select(l => indent + l);

			// Replace content
			var before = lines.Take(startIndex + 1);
			var after = lines.Skip(endIndex);

			var updated = before
				.Concat(EmptyLine)
				.Concat(indented)
				.Concat(EmptyLine)
				.Concat(after);

			File.WriteAllLines(filePath, updated);
		}
	}
}
