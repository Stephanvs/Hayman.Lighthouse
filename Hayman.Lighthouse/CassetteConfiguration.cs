using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Cassette.Configuration;
using Cassette.Stylesheets;
using Cassette.Scripts;
using System.IO;
using Cassette.HtmlTemplates;

namespace Hayman.Lighthouse
{
	public class CassetteConfiguration : ICassetteConfiguration
	{
		public void Configure(BundleCollection bundles, CassetteSettings settings)
		{
			// Stylesheets
			bundles.AddUrlWithAlias<StylesheetBundle>("http://fonts.googleapis.com/css?family=PT+Sans", "font-ptsans");
			bundles.AddUrlWithAlias<StylesheetBundle>("http://fonts.googleapis.com/css?family=Ubuntu:300,400,500,700,300italic,400italic,500italic,700italic", "font-ubuntu");
			bundles.AddPerSubDirectory<StylesheetBundle>("Styles", new FileSearch { Pattern = "*.css;*.less" });

			// Scripts
			bundles.AddPerSubDirectory<ScriptBundle>("Scripts", new FileSearch
			{
			    Pattern = "*.js;*.coffee",
				Exclude = new Regex("-vsdoc\\.js$"), // Excludes the VS documentation files
				SearchOption = SearchOption.AllDirectories
			});

			// HtmlTemplates
			bundles.Add<HtmlTemplateBundle>(
				"HtmlTemplates"
				/*,
				// Assign the jQuery-tmpl processor to the HTML template bundles
				bundle => bundle.Processor = new KnockoutJQueryTmplPipeline()*/);
		}
	}
}