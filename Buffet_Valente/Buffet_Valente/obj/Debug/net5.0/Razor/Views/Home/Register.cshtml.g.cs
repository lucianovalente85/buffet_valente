#pragma checksum "C:\Luciano programas\PWA\2021\buffet_valente\Buffet_Valente\Buffet_Valente\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44eccf8a6a0623b0faf79628ff3d8a56f06eb47e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "C:\Luciano programas\PWA\2021\buffet_valente\Buffet_Valente\Buffet_Valente\Views\_ViewImports.cshtml"
using Buffet_Valente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Luciano programas\PWA\2021\buffet_valente\Buffet_Valente\Buffet_Valente\Views\_ViewImports.cshtml"
using Buffet_Valente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44eccf8a6a0623b0faf79628ff3d8a56f06eb47e", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab35d18f86bb86f4f5d5aff6d8967e5d5cd6dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Luciano programas\PWA\2021\buffet_valente\Buffet_Valente\Buffet_Valente\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Luciano programas\PWA\2021\buffet_valente\Buffet_Valente\Buffet_Valente\Views\Home\Register.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""container"">
    <div class=""form-login"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <div class=""panel-title"">Login do Sistema</div>
            </div>

            <div style=""padding-top:30px"" class=""panel-body"">
                <div style=""display:none"" id=""result"" class=""alert
                    alert-danger col-sm-12"">
                </div>

                <div style=""margin-bottom: 25px"" class=""input-group"">
                    <span class=""input-group-addon"">
                        <i class=""glyphicon
                        glyphicon-user""></i>
                    </span>
                    <input placeholder=""Name"" />
                </div>

                <div style=""margin-bottom: 25px"" class=""input-group"">
                    <span class=""input-group-addon"">
                        <i class=""glyphicon
                        glyphicon-user""></i>
                    </span>
                    ");
            WriteLiteral(@"<input placeholder=""Email"" />
                </div>

                <div style=""margin-bottom: 25px"" class=""input-group"">
                    <span class=""input-group-addon"">
                        <i class=""glyphicon
                        glyphicon-lock""></i>
                    </span>
                    <input placeholder=""password"" />
                </div>

                <div style=""margin-top:10px"" class=""form-group"">
                    <div class=""col-sm-12 controls"">
                        <input type=""submit"" value=""Register""
                               class=""btn primary btn-lg"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
