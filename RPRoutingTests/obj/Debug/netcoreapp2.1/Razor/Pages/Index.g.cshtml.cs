#pragma checksum "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "682b4ba7a688f7deba1aed4e8af31e747af75ee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RPRoutingTests.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(RPRoutingTests.Pages.Pages_Index), null)]
namespace RPRoutingTests.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\_ViewImports.cshtml"
using RPRoutingTests;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682b4ba7a688f7deba1aed4e8af31e747af75ee3", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658506020d001056b35c5db8bdc00fea170af1a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 171, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Area Name</th>\r\n        <th>Relative Path</th>\r\n        <th>View Engine Path</th>\r\n        <th>Template(s)</th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"
     foreach (var entry in Startup.PageRouteModels)
    {

#line default
#line hidden
            BeginContext(302, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(333, 14, false);
#line 17 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"
           Write(entry.AreaName);

#line default
#line hidden
            EndContext();
            BeginContext(347, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(371, 18, false);
#line 18 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"
           Write(entry.RelativePath);

#line default
#line hidden
            EndContext();
            BeginContext(389, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(413, 20, false);
#line 19 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"
           Write(entry.ViewEnginePath);

#line default
#line hidden
            EndContext();
            BeginContext(433, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
#line 20 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"
                 foreach (var selector in entry.Selectors)
            {   
                

#line default
#line hidden
            BeginContext(536, 112, false);
#line 22 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"
            Write(selector.AttributeRouteModel.Template == string.Empty ? "{string.Empty}" : selector.AttributeRouteModel.Template);

#line default
#line hidden
            EndContext();
            BeginContext(649, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 23 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(672, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 26 "C:\Users\mikebrind\Documents\GitHub\RPRoutingTests\RPRoutingTests\Pages\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(715, 8, true);
            WriteLiteral("</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
