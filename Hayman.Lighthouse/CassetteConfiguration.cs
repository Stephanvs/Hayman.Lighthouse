using System.IO;
using System.Text.RegularExpressions;
using Cassette;
using Cassette.Scripts;

namespace Hayman.Lighthouse
{
	/// <summary>
	/// Configures the Cassette asset modules for the web application.
	/// </summary>
	public class CassetteConfiguration : ICassetteConfiguration
	{
		public void Configure(ModuleConfiguration moduleConfiguration, ICassetteApplication application)
		{
			moduleConfiguration.Add(
				new DirectorySource<ScriptModule>("Scripts/lib", "Scripts/app")
					{
						FilePattern = "*.js;*.coffee",
						Exclude = new Regex("-vsdoc\\.js$"), // Excludes the VS documentation files
						SearchOption = SearchOption.TopDirectoryOnly // The default is AllDirectories
					});
		}
	}
}