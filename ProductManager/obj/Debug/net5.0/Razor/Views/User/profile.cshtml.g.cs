#pragma checksum "F:\PRN211\ProjectPRN211\ProductManager\Views\User\profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b215bb975313022f57529f873cc29b511a7280"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_profile), @"mvc.1.0.view", @"/Views/User/profile.cshtml")]
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
#line 1 "F:\PRN211\ProjectPRN211\ProductManager\Views\User\profile.cshtml"
using ProductManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b215bb975313022f57529f873cc29b511a7280", @"/Views/User/profile.cshtml")]
    #nullable restore
    public class Views_User_profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin>
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
#line 8 "F:\PRN211\ProjectPRN211\ProductManager\Views\User\profile.cshtml"
Write(await Html.PartialAsync("Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b215bb975313022f57529f873cc29b511a72802946", async() => {
                WriteLiteral("\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row header\">\r\n\t\t\t<div class=\"text-center col-sm-12\">\r\n\t\t\t\t<h1>\r\n\t\t\t\t\tSunflower\r\n\t\t\t\t</h1>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t");
#nullable restore
#line 20 "F:\PRN211\ProjectPRN211\ProductManager\Views\User\profile.cshtml"
   Write(await Html.PartialAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\t\t<div class=\"row content\">\r\n\t\t\t<div class=\"col-sm-1\"></div>\r\n\t\t\t<div class=\"col-sm-10 row\">\r\n\r\n\t\t\t\t<div class=\"col-sm-4 border rounded\">\r\n\t\t\t\t\t<img src=\"/css/cter.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 606, "\"", 627, 1);
#nullable restore
#line 28 "F:\PRN211\ProjectPRN211\ProductManager\Views\User\profile.cshtml"
WriteAttributeValue("", 612, Model.FullName, 612, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle img-thumbnail img-fluid\" />\r\n\t\t\t\t\t<h2 class=\"text-center\">");
#nullable restore
#line 29 "F:\PRN211\ProjectPRN211\ProductManager\Views\User\profile.cshtml"
                                       Write(Model.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>(Admin)</br></h2>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8 border rounded\">\r\n");
                WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-1\"></div>\r\n\t\t</div>\r\n\r\n\r\n");
                WriteLiteral("\t</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
