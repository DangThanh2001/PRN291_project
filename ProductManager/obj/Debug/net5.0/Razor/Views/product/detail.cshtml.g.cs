#pragma checksum "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e820ad9e0ebcb7791facb02c25a193f90632a39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_detail), @"mvc.1.0.view", @"/Views/product/detail.cshtml")]
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
#line 1 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
using ProductManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e820ad9e0ebcb7791facb02c25a193f90632a39", @"/Views/product/detail.cshtml")]
    #nullable restore
    public class Views_product_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
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
            WriteLiteral("\r\n");
#nullable restore
#line 9 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
Write(await Html.PartialAsync("Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e820ad9e0ebcb7791facb02c25a193f90632a392997", async() => {
                WriteLiteral("\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row header\">\r\n\r\n\t\t\t<div class=\"text-center col-sm-12\">\r\n\t\t\t\t<h1>\r\n\t\t\t\t\tSunflower\r\n\t\t\t\t</h1>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t");
#nullable restore
#line 22 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
   Write(await Html.PartialAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"		<div class=""container-fluid container-sm"">
			<div class=""row content"">
				<div class=""col-sm-2"">
				</div>
				<div class=""col-sm-8 text-center"">
					<div class=""row "">
						<div class=""col-sm-6 "">Product name</div>
						<div class=""col-sm-6 "">");
#nullable restore
#line 31 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                                          Write(Model.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">Quantities</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">");
#nullable restore
#line 37 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                                          Write(Model.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">Original Price</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">");
#nullable restore
#line 43 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                                          Write(Model.OriginalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">Sell Price</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">");
#nullable restore
#line 48 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                                          Write(Model.SellPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">Status</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">\r\n\t\t\t\t\t\t\t<span");
                BeginWriteAttribute("class", " class=\"", 1324, "\"", 1399, 1);
#nullable restore
#line 54 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
WriteAttributeValue("", 1332, Model.Status == 1 ? "badge badge-success" : "badge badge-danger", 1332, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 55 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                            Write(Model.Status == 1 ? "Ready" : "Waiting");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">Notes</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">");
#nullable restore
#line 62 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                                          Write(Model.Notes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">Import date</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">");
#nullable restore
#line 67 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                                          Write(Model.ImportDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">Category</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">\r\n");
#nullable restore
#line 73 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                             foreach (Category o in ViewBag.cate)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                           Write(o.CatName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>\r\n");
#nullable restore
#line 76 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \">Publisher</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 \"><a");
                BeginWriteAttribute("href", " href=\"", 2155, "\"", 2196, 2);
                WriteAttributeValue("", 2162, "/company/detail/", 2162, 16, true);
#nullable restore
#line 82 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
WriteAttributeValue("", 2178, Model.PublisherId, 2178, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 82 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
                                                                                       Write(Model.Publishing.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"col-sm-2\">\r\n\t\t\t\t</div>\r\n\r\n\r\n\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"row text-center\">\r\n\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t<a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 2423, "\"", 2462, 2);
                WriteAttributeValue("", 2430, "/Product/update/", 2430, 16, true);
#nullable restore
#line 96 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\detail.cshtml"
WriteAttributeValue("", 2446, Model.ProductId, 2446, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update</a>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n");
                WriteLiteral("\r\n\r\n\t</div>\r\n\t<style>\r\n\t\ta.btn.btn-primary {\r\n\t\t\tmargin-bottom: 1em;\r\n\t\t}\r\n\t</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
