#pragma checksum "C:\Users\11036379\source\repos\Phase3Project\Phase3Project\Views\main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a71081684fdd591436d07426a3d4fc3d716eb2ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_main_Index), @"mvc.1.0.view", @"/Views/main/Index.cshtml")]
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
#line 1 "C:\Users\11036379\source\repos\Phase3Project\Phase3Project\Views\_ViewImports.cshtml"
using Phase3Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11036379\source\repos\Phase3Project\Phase3Project\Views\_ViewImports.cshtml"
using Phase3Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a71081684fdd591436d07426a3d4fc3d716eb2ad", @"/Views/main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d78a2a047785224f87e7436911728fc190db6cc", @"/Views/_ViewImports.cshtml")]
    public class Views_main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "adminlogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "sellerlogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "customerlogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header id=""i761"" class=""header-banner"">
    <div id=""i37k"" class=""container-width"">
        <div id=""i7h7"" class=""logo-container"">
            <div id=""i7b5"" class=""logo"">
                LapKart
            </div>
        </div>
        <nav id=""ivnh"" class=""menu"">
        </nav>
        <div class=""clearfix"">
        </div>
        <div id=""ig8cl"" class=""lead-title"">
            Find out the best selling laptops here
        </div>
        <div class=""lead-btn"" id=""ird84"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a71081684fdd591436d07426a3d4fc3d716eb2ad4840", async() => {
                WriteLiteral("<b style=\"color:black\">Admin Login</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n        </div>\r\n        <div id=\"i72zi\" class=\"lead-btn\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a71081684fdd591436d07426a3d4fc3d716eb2ad6315", async() => {
                WriteLiteral("<b style=\"color:black\">Seller Login</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div id=\"i378b\" class=\"lead-btn\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a71081684fdd591436d07426a3d4fc3d716eb2ad7790", async() => {
                WriteLiteral("<b style=\"color:black\">Customer Login</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</header>
<style>
    * {
        box-sizing: border-box;
    }

    body {
        margin: 0;
    }

    .clearfix {
        clear: both;
    }

    .header-banner {
        padding-top: 35px;
        padding-bottom: 100px;
        color: #ffffff;
        font-family: Helvetica, serif;
        font-weight: 100;
        background-image: url(""https://grapesjs.com/img/bg-gr-v.png""), url(""https://grapesjs.com/img/work-desk.jpg"");
        background-attachment: scroll, scroll;
        background-position: left top, center center;
        background-repeat: repeat-y, no-repeat;
        background-size: contain, cover;
    }

    .container-width {
        width: 90%;
        max-width: 1150px;
        margin: 0 auto;
    }

    .logo-container {
        float: left;
        width: 50%;
    }

    .logo {
        background-color: #fff;
        border-radius: 5px;
        width: 130px;
        padding: 10px;
        min-height: 30px;
       ");
            WriteLiteral(@" text-align: center;
        line-height: 30px;
        color: #4d114f;
        font-size: 23px;
    }

    .menu {
        float: right;
        width: 50%;
    }

    .lead-title {
        margin: 150px 0 30px 0;
        font-size: 40px;
    }

    .lead-btn {
        margin-top: 15px;
        padding: 10px;
        width: 190px;
        min-height: 30px;
        font-size: 20px;
        text-align: center;
        letter-spacing: 3px;
        line-height: 30px;
        background-color: #d983a6;
        border-radius: 5px;
        transition: all 0.5s ease;
        cursor: pointer;
    }

        .lead-btn:hover {
            background-color: #ffffff;
            color: #4c114e;
        }

        .lead-btn:active {
            background-color: #4d114f;
            color: #fff;
        }

    #i7b5:active {
        border: solid #b16ab3;
        background-image: -webkit-linear-gradient(90deg, rgb(217, 131, 166) 0%, rgb(113, 56, 115) 100%);
        background-r");
            WriteLiteral(@"epeat: repeat;
        background-position: left top;
        background-attachment: scroll;
        background-size: auto;
        opacity: 1;
        color: #eeeeee;
        font-weight: 700;
        font-family: Comic Sans MS, cursive, sans-serif;
    }

    #i7b5 {
        font-family: Lucida Sans Unicode, Lucida Grande, sans-serif;
        background-image: linear-gradient(90deg, #d983a6 0%, #713873 100%);
        background-repeat: repeat;
        background-position: left top;
        background-attachment: scroll;
        background-size: auto;
        color: #eeeeee;
        font-weight: 700;
    }

        #i7b5:hover {
            font-family: Comic Sans MS, cursive, sans-serif;
            font-weight: 800;
            background-image: linear-gradient(90deg, #d983a6 0%, #713873 100%);
            background-repeat: repeat;
            background-position: left top;
            background-attachment: scroll;
            background-size: auto;
            color: #ffffff");
            WriteLiteral(@";
        }

    #ig8cl {
        font-family: Brush Script MT, sans-serif;
        font-weight: 700;
    }

    #i72zi {
        background-image: linear-gradient(90deg, #d983a6 0%, #713873 100%);
        background-repeat: repeat;
        background-position: left top;
        background-attachment: scroll;
        background-size: auto;
    }

    #i378b {
        background-image: linear-gradient(90deg, #d983a6 0%, #713873 100%);
        background-repeat: repeat;
        background-position: left top;
        background-attachment: scroll;
        background-size: auto;
    }

    #ird84 {
        background-image: linear-gradient(90deg, #d983a6 0%, #713873 100%);
        background-repeat: repeat;
        background-position: left top;
        background-attachment: scroll;
        background-size: auto;
    }
</style>");
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