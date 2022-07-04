#pragma checksum "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "470ad1ec8643aaa4ca5b4224f4261939e050b24b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_company_index), @"mvc.1.0.view", @"/Views/company/index.cshtml")]
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
#line 1 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
using ProductManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470ad1ec8643aaa4ca5b4224f4261939e050b24b", @"/Views/company/index.cshtml")]
    #nullable restore
    public class Views_company_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PublishingHouse>>
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
#line 8 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
Write(await Html.PartialAsync("Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "470ad1ec8643aaa4ca5b4224f4261939e050b24b2969", async() => {
                WriteLiteral("\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row header\">\r\n\r\n\t\t\t<div class=\"text-center col-sm-12\">\r\n\t\t\t\t<h1>\r\n\t\t\t\t\tSunflower\r\n\t\t\t\t</h1>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t");
#nullable restore
#line 21 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
   Write(await Html.PartialAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"
		<div class=""row context"">
			<div class=""col-sm-1"">
			</div>
			<div class=""col-sm-10 row"">
				<div class=""col-sm-3"">
				</div>
				<div class=""col-sm-3"">
				</div>
				<div class=""col-sm-4""></div>
				<div class=""col-sm-2"">
					<br>
					<a class=""btn btn-outline-primary my-2 my-sm-0 float-right"" href=""/company/add"">Add more company</a>
				</div>
			</div>
			<div class=""col-sm-1"">
			</div>

		</div>

		<div class=""row content"">
			<div class=""col-sm-1"">
			</div>
			<div class=""col-sm-10"">
				<div>

					<table class=""table table-striped "">
						<thead>
							<tr>
								<th>Name</th>
								<th>Address</th>
								<th>Phone</th>
								<th>URL</th>
								<th>Action</th>

							</tr>
						</thead>
						<tbody>

");
#nullable restore
#line 62 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
                             foreach (PublishingHouse o in Model)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td><a");
                BeginWriteAttribute("href", " href=\"", 1323, "\"", 1360, 2);
                WriteAttributeValue("", 1330, "/company/detail/", 1330, 16, true);
#nullable restore
#line 65 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
WriteAttributeValue("", 1346, o.PublisherId, 1346, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"text-primary\">");
#nullable restore
#line 65 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
                                                                                                 Write(o.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 66 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
                                   Write(o.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 67 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
                                   Write(o.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 69 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
                                         if (string.IsNullOrEmpty(o.Url))
										{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<i>Still not available</i>\r\n");
#nullable restore
#line 72 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
										}
										else
										{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<a");
                BeginWriteAttribute("href", " href=\"", 1627, "\"", 1640, 1);
#nullable restore
#line 75 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
WriteAttributeValue("", 1634, o.Url, 1634, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Redirect</a>\r\n");
#nullable restore
#line 76 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
										}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t<a class=\"text-info\"");
                BeginWriteAttribute("href", " href=\"", 1730, "\"", 1767, 2);
                WriteAttributeValue("", 1737, "/company/detail/", 1737, 16, true);
#nullable restore
#line 79 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
WriteAttributeValue("", 1753, o.PublisherId, 1753, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Details</a>\r\n\t\t\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t\t\t<a class=\"text-info\"");
                BeginWriteAttribute("href", " href=\"", 1828, "\"", 1865, 2);
                WriteAttributeValue("", 1835, "/company/update/", 1835, 16, true);
#nullable restore
#line 81 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
WriteAttributeValue("", 1851, o.PublisherId, 1851, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update</a>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 84 "F:\PRN211\ProjectPRN211\ProductManager\Views\company\index.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-1\">\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\r\n\t\r\n\t</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PublishingHouse>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
