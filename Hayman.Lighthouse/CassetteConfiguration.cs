using System.IO;
using System.Text.RegularExpressions;
using Cassette;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace Hayman.Lighthouse
{
	/// <summary>
	/// Configures the Cassette asset modules for the web application.
	/// </summary>
	public class CassetteConfiguration : ICassetteConfiguration
	{
		public void Configure(ModuleConfiguration moduleConfiguration, ICassetteApplication application)
		{
			// Stylesheets
			moduleConfiguration.Add(
				new ExternalStylesheetModule("font-ptsans", "http://fonts.googleapis.com/css?family=PT+Sans"),
				new ExternalStylesheetModule("font-convergence", "http://fonts.googleapis.com/css?family=Convergence"),
				new PerSubDirectorySource<StylesheetModule>("Styles")
					{
						FilePattern = "*.css;*.less"
					});		
	
			// Scripts
			moduleConfiguration.Add(new PerSubDirectorySource<ScriptModule>("Scripts")
					{
						FilePattern = "*.js;*.coffee",
						Exclude = new Regex("-vsdoc\\.js$"), // Excludes the VS documentation files
						SearchOption = SearchOption.AllDirectories
					});
		}
	}
}