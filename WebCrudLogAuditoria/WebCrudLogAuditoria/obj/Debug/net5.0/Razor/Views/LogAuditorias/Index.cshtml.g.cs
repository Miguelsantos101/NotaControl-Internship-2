#pragma checksum "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\LogAuditorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3f3bdc92126c9ce7eed0723b3f2a206670405b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogAuditorias_Index), @"mvc.1.0.view", @"/Views/LogAuditorias/Index.cshtml")]
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
#line 1 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\_ViewImports.cshtml"
using WebCrudLogAuditoria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\_ViewImports.cshtml"
using WebCrudLogAuditoria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f3bdc92126c9ce7eed0723b3f2a206670405b4", @"/Views/LogAuditorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31859fa411e7bd38af597e23ae91ff1c39bd7b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_LogAuditorias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebCrudLogAuditoria.Models.LogAuditoria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\LogAuditorias\Index.cshtml"
  
    ViewData["Title"] = "Log Auditoria";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Log Auditoria</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\LogAuditorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DetalhesAuditoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\LogAuditorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\LogAuditorias\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\LogAuditorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DetalhesAuditoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\LogAuditorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Dev_T2\WebCrudLogAuditoria\WebCrudLogAuditoria\Views\LogAuditorias\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebCrudLogAuditoria.Models.LogAuditoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591