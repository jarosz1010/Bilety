#pragma checksum "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\Pracownicy\Zaloguj_admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86c3f7e0c26271b7b36d35ab48ce1fa6579097af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pracownicy_Zaloguj_admin), @"mvc.1.0.view", @"/Views/Pracownicy/Zaloguj_admin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pracownicy/Zaloguj_admin.cshtml", typeof(AspNetCore.Views_Pracownicy_Zaloguj_admin))]
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
#line 1 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7;

#line default
#line hidden
#line 2 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c3f7e0c26271b7b36d35ab48ce1fa6579097af", @"/Views/Pracownicy/Zaloguj_admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc31cafed32aad956e8e002afa406e7283b5ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Pracownicy_Zaloguj_admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication7.Models.Pracownik>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\Pracownicy\Zaloguj_admin.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(70, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(99, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24fea0f84e104b2f9e1515956f1059af", async() => {
                BeginContext(105, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Zaloguj</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(201, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(203, 255, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d740d1f73cd48c8a118bf51713bcd64", async() => {
                BeginContext(209, 71, true);
                WriteLiteral("\r\n\r\n    Witaj adminie!\r\n\r\n\r\n    <input type=\"button\" value=\"Pracownicy\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 280, "\"", 340, 3);
                WriteAttributeValue("", 290, "location.href=\'", 290, 15, true);
#line 19 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\Pracownicy\Zaloguj_admin.cshtml"
WriteAttributeValue("", 305, Url.Action("Index", "Pracownicy"), 305, 34, false);

#line default
#line hidden
                WriteAttributeValue("", 339, "\'", 339, 1, true);
                EndWriteAttribute();
                BeginContext(341, 44, true);
                WriteLiteral("  />\r\n    <input type=\"button\" value=\"Trasy\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 385, "\"", 444, 3);
                WriteAttributeValue("", 395, "location.href=\'", 395, 15, true);
#line 20 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\Pracownicy\Zaloguj_admin.cshtml"
WriteAttributeValue("", 410, Url.Action("Index","Polaczenia"), 410, 33, false);

#line default
#line hidden
                WriteAttributeValue("", 443, "\'", 443, 1, true);
                EndWriteAttribute();
                BeginContext(445, 6, true);
                WriteLiteral("  />\r\n");
                EndContext();
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
            EndContext();
            BeginContext(458, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication7.Models.Pracownik> Html { get; private set; }
    }
}
#pragma warning restore 1591