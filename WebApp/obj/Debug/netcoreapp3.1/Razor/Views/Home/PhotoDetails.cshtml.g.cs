#pragma checksum "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e4c161c3f7e4987a8c842251282516957baf085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PhotoDetails), @"mvc.1.0.view", @"/Views/Home/PhotoDetails.cshtml")]
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
#line 1 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e4c161c3f7e4987a8c842251282516957baf085", @"/Views/Home/PhotoDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PhotoDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.PhotoDetails>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
  
    ViewData["Title"] = "PhotoDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<h1>Photo Details</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4c161c3f7e4987a8c842251282516957baf0853615", async() => {
                WriteLiteral("\r\n    <div class=\"form-group row\">\r\n        <label class=\"col-sm-2 col-form-label\">Photo ID:</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
       Write(Model.response.photo.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group row\">\r\n        <label class=\"col-sm-2 col-form-label\">Created At:</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
       Write(DateTimeOffset.FromUnixTimeSeconds(long.Parse(Model.response.photo.createdAt)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group row\">\r\n        <label class=\"col-sm-2 col-form-label\">Source:</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
       Write(Model.response.photo.source.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group row\">\r\n        <label class=\"col-sm-2 col-form-label\">Source URL:</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
       Write(Model.response.photo.source.url);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group row\">\r\n        <label class=\"col-sm-2 col-form-label\">URL:</label>\r\n        <div class=\"col-sm-10\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1145, "\"", 1263, 4);
#nullable restore
#line 43 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
WriteAttributeValue("", 1152, Model.response.photo.prefix, 1152, 28, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
WriteAttributeValue("", 1180, Model.response.photo.width, 1180, 27, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
WriteAttributeValue("", 1207, Model.response.photo.height, 1207, 28, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\windows pc\source\repos\IMMEDIA-SkillsAssignment\WebApp\Views\Home\PhotoDetails.cshtml"
WriteAttributeValue("", 1235, Model.response.photo.suffix, 1235, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Foursquare Link</a>\r\n        </div>\r\n    </div>   \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.PhotoDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
