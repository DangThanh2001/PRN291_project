#pragma checksum "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cead629080695bcbc8a602b4b1823968b844da96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Update), @"mvc.1.0.view", @"/Views/Category/Update.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
using ProductManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cead629080695bcbc8a602b4b1823968b844da96", @"/Views/Category/Update.cshtml")]
    #nullable restore
    public class Views_Category_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
Write(await Html.PartialAsync("Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cead629080695bcbc8a602b4b1823968b844da962970", async() => {
                WriteLiteral("\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row header\">\r\n\t\t\t<div class=\"text-center col-sm-12\">\r\n\t\t\t\t<h1>\r\n\t\t\t\t\tSunflower\r\n\t\t\t\t</h1>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t");
#nullable restore
#line 20 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
   Write(await Html.PartialAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\t\t<div class=\"row content\">\r\n\r\n\t\t\t<div class=\"col-sm-2\"></div>\r\n\t\t\t<div class=\"col-sm-8\">\r\n");
#nullable restore
#line 26 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
                 if (ViewBag.ok == 1)
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div class=\"alert alert-success text-center\" id=\"alertdiv\" role=\"alert\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 29 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
                   Write(ViewBag.mess);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 31 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div class=\"alert alert-danger\" id=\"alertdiv\" role=\"alert\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 35 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
                   Write(ViewBag.mess);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t<form");
                BeginWriteAttribute("action", " action=\"", 819, "\"", 881, 2);
                WriteAttributeValue("", 828, "/category/", 828, 10, true);
#nullable restore
#line 39 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
WriteAttributeValue("", 838, ViewBag.act == null ? "doupdate":"doadd", 838, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" method=\"post\">\r\n\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"upCat.CatId\"");
                BeginWriteAttribute("value", " value=\"", 975, "\"", 995, 1);
#nullable restore
#line 41 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
WriteAttributeValue("", 983, Model.CatId, 983, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t<label for=\"proName\">Category name:</label>\r\n\t\t\t\t\t\t<input type=\"text\" id=\"proName\" class=\"form-control\" placeholder=\"Category name\" required name=\"upCat.CatName\"");
                BeginWriteAttribute("value", " value=\"", 1166, "\"", 1188, 1);
#nullable restore
#line 43 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
WriteAttributeValue("", 1174, Model.CatName, 1174, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t<label for=\"note\">Descriptions:</label>\r\n\t\t\t\t\t\t<textarea name=\"upCat.CatNote\" id=\"note\" class=\"form-control\">");
#nullable restore
#line 48 "F:\PRN211\ProjectPRN211\ProductManager\Views\Category\Update.cshtml"
                                                                                 Write(Model.CatNote);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n\t\t\t\t</form>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-2\"></div>\r\n\t\t</div>\r\n\r\n");
                WriteLiteral(@"	</div>

	<style>
		textarea#note {
			height: 15em;
		}
	</style>

	<script type=""text/javascript"">
		// close the div in 5 secs
		window.setTimeout(""closeHelpDiv();"", 5000);

		function closeHelpDiv(){
		document.getElementById(""alertdiv"").style.display="" none"";
		}
	</script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
