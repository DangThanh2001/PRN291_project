#pragma checksum "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd92611a2b33f5bd164ff46e3a97e4285e4faef1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_index), @"mvc.1.0.view", @"/Views/product/index.cshtml")]
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
#line 1 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
using ProductManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd92611a2b33f5bd164ff46e3a97e4285e4faef1", @"/Views/product/index.cshtml")]
    #nullable restore
    public class Views_product_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
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
#line 9 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
Write(await Html.PartialAsync("Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd92611a2b33f5bd164ff46e3a97e4285e4faef12996", async() => {
                WriteLiteral("\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row header\">\r\n\r\n\t\t\t<div class=\"text-center col-sm-12\">\r\n\t\t\t\t<h1>Sunflower</h1>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t");
#nullable restore
#line 20 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
   Write(await Html.PartialAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

		<div class=""row"">
			<div class=""col-sm-1"">
			</div>
			<div class=""col-sm-10 row"">
				<div class=""col-sm-3"">
					<strong><i>Publisher</i></strong>
					<form action=""/product/index"" method=""post"">
						<select name=""par1"" class=""custom-select"" onchange=""this.form.submit()"">
							<option");
                BeginWriteAttribute("value", " value=\"", 718, "\"", 726, 0);
                EndWriteAttribute();
                WriteLiteral(">View all</option>\r\n");
#nullable restore
#line 31 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                             foreach (PublishingHouse o in ViewBag.allCom)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<option");
                BeginWriteAttribute("value", " value=\"", 827, "\"", 842, 1);
#nullable restore
#line 33 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 835, o.Name, 835, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 33 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                                    Write(ViewBag.seacrh.Equals(o.Name) ? "selected" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">");
#nullable restore
#line 33 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                                                                                      Write(o.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 34 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"						</select>
					</form>

				</div>
				<div class=""col-sm-3"">
					<strong><i>Status</i></strong>
					<form action=""/product/listStatus"" method=""post"">
						<select name=""par1"" class=""custom-select"" onchange=""this.form.submit()"">
							<option value=""5"">View all</option>
							<option value=""0"">Waiting</option>
							<option value=""1"">Ready</option>

						</select>
					</form>
				</div>
				<div class=""col-sm-4""></div>
				<div class=""col-sm-2"">
					<br>
					<a class=""btn btn-outline-primary my-2 my-sm-0 float-right"" href=""/product/add"">Add more product</a>
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
								<th scope=""col"">Product</th>
								<th scope=""col"">Quantity</th>
								<th scope=""col"">Original Price</th>
								<th scope=""col"">Sell price</th>
								<t");
                WriteLiteral("h scope=\"col\">status</th>\r\n\t\t\t\t\t\t\t\t<th scope=\"col\">Publisher</th>\r\n\t\t\t\t\t\t\t\t<th scope=\"col\">Action</th>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t</thead>\r\n\t\t\t\t\t\t<tbody>\r\n");
#nullable restore
#line 79 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                             if (Model.Count == 0)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td colspan=\"7\" class=\"text-center\">\r\n\t\t\t\t\t\t\t\t\t\t<i>No records found...</i>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 86 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
							}
							else
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                 foreach (Product o in Model)
								{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td scope=\"row\"><a class=\"text-info\"");
                BeginWriteAttribute("href", " href=\"", 2411, "\"", 2446, 2);
                WriteAttributeValue("", 2418, "/Product/detail/", 2418, 16, true);
#nullable restore
#line 92 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 2434, o.ProductId, 2434, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 92 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                                                                                            Write(o.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<form");
                BeginWriteAttribute("action", " action=\"", 2505, "\"", 2544, 2);
                WriteAttributeValue("", 2514, "/product/quantity/", 2514, 18, true);
#nullable restore
#line 94 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 2532, o.ProductId, 2532, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" method=\"post\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"input-group mb-3\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"upPro.ProductId\"");
                BeginWriteAttribute("value", " value=\"", 2662, "\"", 2682, 1);
#nullable restore
#line 96 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 2670, o.ProductId, 2670, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"number\" class=\"form-control\"\r\n\t\t\t\t\t\t\t\t\t\t\t\t   name=\"UpPro.Quantity\"");
                BeginWriteAttribute("value", " value=\"", 2778, "\"", 2797, 1);
#nullable restore
#line 98 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 2786, o.Quantity, 2786, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("aria-label", " aria-label=\"", 2798, "\"", 2811, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t   aria-describedby=\"basic-addon2\" min=\"0\" max=\"9999999\"\r\n\t\t\t\t\t\t\t\t\t\t\t\t   ");
#nullable restore
#line 100 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                               Write(o.Status == 0 ? "readonly" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"input-group-append\">\r\n");
#nullable restore
#line 103 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                                         if (o.Status == 1)
														{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"submit\" class=\"btn btn-outline-success my-2 my-sm-0\"\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t   value=\"Enter\" id=\"basic-addon2\">\r\n");
#nullable restore
#line 107 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
														}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t</form>\r\n\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 115 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                       Write(o.OriginalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 116 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                       Write(o.SellPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<span");
                BeginWriteAttribute("class", " class=\"", 3376, "\"", 3447, 1);
#nullable restore
#line 118 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 3384, o.Status == 1 ? "badge badge-success" : "badge badge-danger", 3384, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 119 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                            Write(o.Status == 1 ? "Ready" : "Waiting");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t<td><a");
                BeginWriteAttribute("href", " href=\"", 3558, "\"", 3595, 2);
                WriteAttributeValue("", 3565, "/company/detail/", 3565, 16, true);
#nullable restore
#line 123 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 3581, o.PublisherId, 3581, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 123 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                                                                Write(o.Publisher.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<a class=\"text-info\"");
                BeginWriteAttribute("href", " href=\"", 3672, "\"", 3707, 2);
                WriteAttributeValue("", 3679, "/Product/detail/", 3679, 16, true);
#nullable restore
#line 125 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 3695, o.ProductId, 3695, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Details</a>\r\n\t\t\t\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t\t\t\t<a class=\"text-info\"");
                BeginWriteAttribute("href", " href=\"", 3770, "\"", 3805, 2);
                WriteAttributeValue("", 3777, "/Product/update/", 3777, 16, true);
#nullable restore
#line 127 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 3793, o.ProductId, 3793, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update</a>\r\n\t\t\t\t\t\t\t\t\t\t\t<br>\r\n");
#nullable restore
#line 129 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                             if (o.Quantity > 0)
											{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<a");
                BeginWriteAttribute("class", " class=\"", 3897, "\"", 3954, 1);
#nullable restore
#line 131 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 3905, o.Status == 1 ? "text-danger" : "text-success", 3905, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 3955, "\"", 3990, 2);
                WriteAttributeValue("", 3962, "/product/status/", 3962, 16, true);
#nullable restore
#line 131 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 3978, o.ProductId, 3978, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Change status</a>\r\n");
#nullable restore
#line 132 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
											}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 135 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
								}

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                                 
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"float-right\">\r\n");
                WriteLiteral("\t\t\t\t\t<div class=\"d-flex flex-row\"\">\r\n\t\t\t\t\t\t<div class=\"p-2\">\r\n");
#nullable restore
#line 144 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                             if (ViewBag.curPage != 1)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<a");
                BeginWriteAttribute("href", " href=\"", 4306, "\"", 4364, 4);
                WriteAttributeValue("", 4313, "/product/index/", 4313, 15, true);
#nullable restore
#line 146 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 4328, ViewBag.seacrh, 4328, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4343, "/", 4343, 1, true);
#nullable restore
#line 146 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 4344, ViewBag.curPage-1, 4344, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Prev</a>\r\n");
#nullable restore
#line 147 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"p-2\">\r\n\t\t\t\t\t\t\t<form action=\"/product/index\" method=\"post\">\r\n\t\t\t\t\t\t\t\t<input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4508, "\"", 4531, 1);
#nullable restore
#line 152 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 4516, ViewBag.seacrh, 4516, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"par1\" />\r\n\t\t\t\t\t\t\t\t<label for=\"num\">\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control text-center\" id=\"num\" onchange=\"this.form.submit()\"\r\n\t\t\t\t\t\t\t\t\t\t   type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 4691, "\"", 4715, 1);
#nullable restore
#line 155 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 4699, ViewBag.curPage, 4699, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"par2\" required min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 4745, "\"", 4767, 1);
#nullable restore
#line 155 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 4751, ViewBag.allPage, 4751, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t</label\r\n\t\t\t\t\t\t\t</form>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"p-2\">\r\n");
#nullable restore
#line 161 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
                             if (ViewBag.curPage != @ViewBag.allPage)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<a");
                BeginWriteAttribute("href", " href=\"", 4917, "\"", 4975, 4);
                WriteAttributeValue("", 4924, "/product/index/", 4924, 15, true);
#nullable restore
#line 163 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 4939, ViewBag.seacrh, 4939, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4954, "/", 4954, 1, true);
#nullable restore
#line 163 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
WriteAttributeValue("", 4955, ViewBag.curPage+1, 4955, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Next</a>\r\n");
#nullable restore
#line 164 "F:\PRN211\ProjectPRN211\ProductManager\Views\product\index.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-1\">\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n");
                WriteLiteral("\t\t<style>\r\n\t\t.d-flex {\r\n    display: -ms-flexbox!important;\r\n    display: flex!important;\r\n    align-items: baseline;\r\n}\r\n\t\t</style>\r\n\t</div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
