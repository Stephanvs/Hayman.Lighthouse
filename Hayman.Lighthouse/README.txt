Add Foundation template to MVC 3 (Razor) project
Install the NuGet package using Visual Studio Library Package Manager
Tools > Library Package Manager > Add Library Package Reference
Search for Zurb Foundation

After the files are added to the project open the /Views/_ViewStart.cshtml
Change the Layout to the new _Foundation.cshtml

@{
    //This is the default MVC template
    //Layout = "~/Views/Shared/_Layout.cshtml";
    
    //This is the Foundation MVC template
    Layout = "~/Views/Shared/_Foundation.cshtml";
}

Once the ViewStart has been updated. Replace the default Index.cshtml.
Rename ~/Views/Home/Index.cshtml to Index.cshtml.exclude (or delete the file)
Rename ~/Views/Home/Foundation_Index.cshtml to Index.cshtml

Rename ~/Content/Site.css to Site.css.exclude (or delete the file)

Add this using to Global.asax

using Microsoft.Web.Optimization;

Add this to Application_Start in Global.asax 

BundleTable.Bundles.EnableDefaultBundles();

You are now ready to begin building your MVC project using Foundation.

Files added during install:
~/Content/core
~/Content/core/app.css
~/Content/core/forms.css
~/Content/core/global.css
~/Content/core/grid.css
~/Content/core/orbit.css
~/Content/core/reveal.css
~/Content/core/typography.css
~/Content/core/ui.css

~/Content/ie.css
~/Content/mobile.css

~/Content/foundation/misc
~/Content/foundation/misc/button-gloss.png
~/Content/foundation/misc/button-overlay.png
~/Content/foundation/misc/custom-form-sprites.png
~/Content/foundation/misc/input-bg.png
~/Content/foundation/misc/modal-gloss.png
~/Content/foundation/misc/table-sorter.png

~/Content/foundation/orbit
~/Content/foundation/orbit/bullets.jpg
~/Content/foundation/orbit/left-arrow.png
~/Content/foundation/orbit/loading.gif
~/Content/foundation/orbit/mask-black.png
~/Content/foundation/orbit/pause-black.png
~/Content/foundation/orbit/right-arrow.png
~/Content/foundation/orbit/rotator-black.png
~/Content/foundation/orbit/timer-black.png

~/Scripts/app.js
~/Scripts/forms.jquery.js
~/Scripts/jquery.customforms.js
~/Scripts/jquery.min.js
~/Scripts/jquery.orbit-1.3.0.js
~/Scripts/jquery.placeholder.min.js
~/Scripts/jquery.reveal.js

~/humans.txt
~/robots.txt
~/MIT-LICENSE.txt
~/README.txt (this file)

~/Views/Home/Foundation_Index.cshtml

~/Views/Shared/_Foundation.cshtml

Dependencies:
Microsoft.Web.Optimization
