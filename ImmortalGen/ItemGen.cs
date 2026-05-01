using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
	public class ItemGen
	{
		public const string GenDataPath = "Items.txt";
		public const string DefCodePath = "ItemDefs.cs";

		public static void Generate()
		{
			try
			{
				var outputPath = GenUtils.GetDefCodePath(DefCodePath);
				var lines = GenUtils.GetGenData(GenDataPath);
				if (lines == null) return;

				// Build generated code lines
				var generated = new List<string>();
				foreach (var l in lines)
				{
					var line = l.Trim();
					if (string.IsNullOrWhiteSpace(line)) continue;

					if (GenUtils.TryAddComment(line, generated)) continue;
					generated.Add($"public static Item {line} {{ get; }} = Define(nameof({line}));");
				}

				GenUtils.ReplaceCode(outputPath, "Item", generated);
			}
			catch (Exception ex)
			{
				"Item generation failed:".qwe();
				ex.qwe();
			}
		}
	}
}
