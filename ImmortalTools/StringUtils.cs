using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
	public static class StringUtils
	{
		public const string PathSeparator = "/";
		public const string TripleUnderscore = "___";

		public static int ParseInt(this string from)
		{
			return int.Parse(from);
		}

		public static string FromTo(this string str, int start, int end)
		{
			return str[start..end];
		}

		/// <summary>
		/// Excludes separators
		/// </summary>
		public static string FromToMatch(this string str, string start, string end)
		{
			var parts = str.Split(start);
			return parts.Length == 1 ? "" : parts[1].Split(end)[0];
		}

		/// <summary>
		/// Excludes separator
		/// </summary>
		public static string UpToMatch(this string str, string end)
		{
			return str.Split(end)[0];
		}

		/// <summary>
		/// Excludes separator
		/// </summary>
		public static string FromLastMatch(this string str, string start)
		{
			var parts = str.Split(start);
			return parts.Length == 1 ? "" : parts[^1];
		}

		/// <summary>
		/// Excludes separator
		/// </summary>
		public static string FromLastMatchOrKeep(this string str, string start)
		{
			var parts = str.Split(start);
			return parts.Length == 1 ? str : parts[^1];
		}

		public static string RemoveLast(this string str)
		{
			return str[..^1];
		}

		public static string FirstCharAsString(this string str)
		{
			return str[..1];
		}

		public static string LastCharAsString(this string str)
		{
			return str[^1..];
		}

		public static string Join(this string str1, string str2, string separator = "")
		{
			return str1 + separator + str2;
		}

		public static string JoinPath(this string str1, string str2) => Join(str1, str2, PathSeparator);

		public static string Repeat(this string str, int amount = 2)
		{
			for (int i = 1; i < amount; i++)
			{
				str += str;
			}
			return str;
		}

		public static string ToTextCase(this string input)
		{
			if (string.IsNullOrEmpty(input))
				return string.Empty;

			var sb = new StringBuilder();
			sb.Append(char.ToUpper(input[0])); // Capitalize first char

			for (int i = 1; i < input.Length; i++)
			{
				char current = input[i];
				char prev = input[i - 1];
				char next = i < input.Length - 1 ? input[i + 1] : '\0';

				bool isCurrentUpper = char.IsUpper(current);
				bool isPrevUpper = char.IsUpper(prev);
				bool isNextLower = next != '\0' && char.IsLower(next);

				if (isCurrentUpper)
				{
					if (!isPrevUpper)
					{
						// transition from lowercase -> uppercase
						sb.Append(' ');
					}
					else if (isNextLower)
					{
						// e.g. "XMLParser" -> add space before Parser (X M L Parser -> but grouped XML Parser)
						sb.Append(' ');
					}
				}
				else if (char.IsDigit(current) && !char.IsDigit(prev))
				{
					// split digits from letters
					sb.Append(' ');
				}

				sb.Append(current);
			}

			return sb.ToString().Trim();
		}
	}
}
