#pragma checksum "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b3d2a7b770c29ba5a15f44d66ab560437785426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CardTokenizeFail), @"mvc.1.0.view", @"/Views/Home/CardTokenizeFail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CardTokenizeFail.cshtml", typeof(AspNetCore.Views_Home_CardTokenizeFail))]
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
#line 1 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples;

#line default
#line hidden
#line 2 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3d2a7b770c29ba5a15f44d66ab560437785426", @"/Views/Home/CardTokenizeFail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CardTokenizeFail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wirecard.DeveloperPortal.Core.Response.CCTokenizeResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml"
  
    ViewBag.Title = "CardTokenizeFail";

#line default
#line hidden
            BeginContext(114, 33, true);
            WriteLiteral("\r\n<h2>CardTokenizeFail</h2>\r\n\r\n\r\n");
            EndContext();
#line 9 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml"
  
    ViewBag.Title = "Başarısız Kart Saklama İşlemi";

#line default
#line hidden
            BeginContext(208, 240, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"col-md-6\">\r\n    <fieldset>\r\n        <!-- Form Name -->\r\n\r\n        <div class=\"col-md-12\">\r\n            <label class=\"col-md-4 control-label\" for=\"\">  StatusCode</label>\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(449, 16, false);
#line 22 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml"
           Write(Model.StatusCode);

#line default
#line hidden
            EndContext();
            BeginContext(465, 204, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <label class=\"col-md-4 control-label\" for=\"\"> Result Code: </label>\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(670, 16, false);
#line 28 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml"
           Write(Model.ResultCode);

#line default
#line hidden
            EndContext();
            BeginContext(686, 208, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <label class=\"col-md-4 control-label\" for=\"\">  Result Message: </label>\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(895, 19, false);
#line 34 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml"
           Write(Model.ResultMessage);

#line default
#line hidden
            EndContext();
            BeginContext(914, 200, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <label class=\"col-md-4 control-label\" for=\"\"> TokenId: </label>\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(1115, 13, false);
#line 40 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml"
           Write(Model.TokenId);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 203, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <label class=\"col-md-4 control-label\" for=\"\"> MaskedCCNo: </label>\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(1332, 16, false);
#line 46 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml"
           Write(Model.MaskedCCNo);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 203, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <label class=\"col-md-4 control-label\" for=\"\"> CustomerId: </label>\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(1552, 16, false);
#line 52 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\CardTokenizeFail.cshtml"
           Write(Model.CustomerId);

#line default
#line hidden
            EndContext();
            BeginContext(1568, 75, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    \r\n    </fieldset>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wirecard.DeveloperPortal.Core.Response.CCTokenizeResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
