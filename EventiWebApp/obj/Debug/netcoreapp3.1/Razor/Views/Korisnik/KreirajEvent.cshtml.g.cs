#pragma checksum "C:\Users\jopy_\OneDrive\Desktop\PMA_Eventi_JospiaRadak\EventiWebApp\EventiWebApp\Views\Korisnik\KreirajEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bddf54e4f766a55d64c72a46323ae3be4c79204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Korisnik_KreirajEvent), @"mvc.1.0.view", @"/Views/Korisnik/KreirajEvent.cshtml")]
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
#line 1 "C:\Users\jopy_\OneDrive\Desktop\PMA_Eventi_JospiaRadak\EventiWebApp\EventiWebApp\Views\_ViewImports.cshtml"
using EventiWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jopy_\OneDrive\Desktop\PMA_Eventi_JospiaRadak\EventiWebApp\EventiWebApp\Views\_ViewImports.cshtml"
using EventiWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bddf54e4f766a55d64c72a46323ae3be4c79204", @"/Views/Korisnik/KreirajEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba2c780577e12b7ece9d61237c7539af65388d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Korisnik_KreirajEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Korisnik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KreirajEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bddf54e4f766a55d64c72a46323ae3be4c792045475", async() => {
                WriteLiteral(@"
    <style>
        * {
            box-sizing: border-box;
            outline: none;
            list-style: none;
            text-decoration: none;
            font-family: 'Josefin Sans', sans-serif;
        }

        body {
            background: #ffffff;
        }

        .outline_ {
            padding: 35px 40px;
        }

        .wrapper {
            max-width: 400px;
            width: 100%;
            height: auto;
            max-height: 920px;
            position: absolute;
            margin-top: 150px;
            top: 70%;
            left: 50%;
            transform: translate(-50%,-50%);
            background: #ffffff;
            box-shadow: -3px -3px 7px #ffffff73, 2px 2px 5px rgba(94, 104, 121, 0.288);
        }

            .wrapper .tabs ul {
                width: 100%;
                margin-bottom: 30px;
                box-shadow: 2px 2px 5px #babecc, -5px -5px 10px #ffffff73;
                display: flex;
            }

           ");
                WriteLiteral(@"     .wrapper .tabs ul li {
                    width: 50%;
                    padding: 15px 0;
                    text-align: center;
                    font-size: 14px;
                    color: #51c2a9;
                    font-weight: bold;
                    text-transform: uppercase;
                    letter-spacing: 2px;
                    cursor: pointer;
                    position: relative;
                    transition: all 0.5s ease;
                }

                    .wrapper .tabs ul li.active {
                        background: #ffffff;
                        color: rgb(0, 0, 0);
                        box-shadow: inset 2px 2px 5px #babecc, inset -5px -5px 10px #ffffff73;
                    }

            .wrapper .input_field {
                margin-bottom: 25px;
            }

                .wrapper .input_field .input {
                    width: 100%;
                    border: none;
                    background: #ffffff;
               ");
                WriteLiteral(@"     color: black;
                    font-family: sans-serif;
                    box-shadow: inset 2px 2px 5px #babecc, inset -5px -5px 10px #ffffff73;
                    font-size: 14px;
                    padding: 17px;
                    border-radius: 10px;
                }

            .wrapper .btn {
                margin-top: 30px;
                background: #ffffff;
                box-shadow: 2px 2px 5px #babecc, -5px -5px 10px #ffffff73;
                padding: 12px;
                text-align: center;
                border-radius: 10px;
                text-transform: uppercase;
                letter-spacing: 3px;
                font-weight: bold;
            }

                .wrapper .btn:hover {
                    color: #3498db;
                    box-shadow: inset 2px 2px 5px #babecc, inset -5px -5px 10px #ffffff73;
                }

                .wrapper .btn a {
                    color: rgb(0, 0, 0);
                    display: block;
      ");
                WriteLiteral(@"              font-size: 16px;
                    font-family: sans-serif;
                }
            .wrapper .btn_ {
                background: #ffffff;
                border: none;
                letter-spacing: 3px;
                font-weight: bold;
                font-size: 16px;
                font-family: sans-serif;
                text-transform: uppercase;
            }
            .wrapper .select {
                margin-top: 30px;
                background: #ffffff;
                border: none;
                box-shadow: inset 2px 2px 5px #babecc, inset -5px -5px 10px #ffffff73;
                padding: 12px;
                text-align: center;
                border-radius: 10px;
                font-family: sans-serif;
            }
            .wrapper .btn_ {
                background: #ffffff;
                border: none;
                letter-spacing: 3px;
                font-weight: bold;
                font-size: 16px;
                font-fam");
                WriteLiteral("ily: sans-serif;\r\n                text-transform: uppercase;\r\n            }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n    <div class=\"wrapper\">\r\n        <div class=\"outline_\">\r\n\r\n            <div class=\"tabs\">\r\n                <h2>Kreiraj novi event!</h2>\r\n                <br />\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bddf54e4f766a55d64c72a46323ae3be4c7920411028", async() => {
                WriteLiteral(@"
                <div class=""sign_up"">
                    <div class=""input_field"">
                        <input type=""text"" placeholder=""Naziv"" class=""input"" name=""naziv"">
                    </div>
                    <div class=""input_field"">
                        <input type=""datetime-local"" class=""input"" name=""vrijeme"">
                    </div>
                    <div class=""input_field"">
                        <select class=""select"" id=""select_mjesto"" name=""mjesto"">
                        </select>
                    </div>
                    <div class=""input_field"">
                        <input type=""text"" placeholder=""Adresa"" class=""input"" name=""adresa"">
                    </div>
                    <div class=""input_field"">
                        <input type=""text"" placeholder=""Cijena"" class=""input"" name=""cijena"">
                    </div>
                    <div class=""input_field"">
                        <select class=""select"" id=""select_vrsta"" name=""vrstaEven");
                WriteLiteral("ta\">\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"input_field\">\r\n                        <select class=\"select\" name=\"ograniceniPosjetitelji\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bddf54e4f766a55d64c72a46323ae3be4c7920412638", async() => {
                    WriteLiteral("Negraničeni broj posjetitelja");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bddf54e4f766a55d64c72a46323ae3be4c7920413913", async() => {
                    WriteLiteral("Ograničeni broj posjetitelja");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"btn\"><input class=\"btn_\" type=\"submit\" name=\"kreirajEvent\" value=\"Kreiraj\" /></div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <br />
        <br />
        <br />
        <br />
    </div>
</div>

<script type=""text/javascript"">
    function appendToSelectMjesto(data) {
        for (var i = 0; i < data.length; i++) {
            let mjesto = data[i];
            let select = document.getElementById(""select_mjesto"");
            let option = document.createElement(""option"");
            option.value = mjesto.idMjesto;
            option.text = mjesto.naziv;
            select.add(option);
        }
    }
    axios.get('/api/korisnik/svamjesta').then(response => appendToSelectMjesto(response.data))

    function appendToSelectVrsta(data) {
        for (var i = 0; i < data.length; i++) {
            let vrsta = data[i];
            let select = document.getElementById(""select_vrsta"");
            let option = document.createElement(""option"");
            option.value = vrsta.idVrsta;
            option.text = vrsta.naziv;
            select.add(option);
        }
    }
    axios.g");
            WriteLiteral("et(\'/api/korisnik/svevrste\').then(response => appendToSelectVrsta(response.data))\r\n\r\n</script>");
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