#pragma checksum "C:\Users\jopy_\OneDrive\Desktop\PMA_Eventi_JospiaRadak\EventiWebApp\EventiWebApp\Views\Admin\Vrste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a402f85c003467e737d9544f0d5ceb8218086910"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Vrste), @"mvc.1.0.view", @"/Views/Admin/Vrste.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a402f85c003467e737d9544f0d5ceb8218086910", @"/Views/Admin/Vrste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba2c780577e12b7ece9d61237c7539af65388d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Vrste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary my-2 my-sm-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KreirajVrstu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("podnesi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a402f85c003467e737d9544f0d5ceb82180869105378", async() => {
                WriteLiteral("Dodaj vrstu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a402f85c003467e737d9544f0d5ceb82180869107037", async() => {
                WriteLiteral(@"
    <table style=""margin-left: 30%;"">
        <td style=""width: 140px; padding: 10px;""><input type=""text"" id=""id"" class=""form-control"" disabled></td>
        <td style=""width: 140px; padding: 10px;""><input type=""text"" id=""nazivVrste"" class=""form-control""></td>
        <td style=""width: 100px; padding: 10px;""><input class=""btn btn-outline-success btn-lg"" type=""button"" onclick=""promijeniNaziv()"" value=""Uredi"" /></td>
        <td style=""width: 140px; padding: 10px;""><button type=""button"" class=""btn btn-outline-danger btn-lg"" onclick=""odustani()"">Odustajem</button></td>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""table-responsive-sm"">
    <table class=""table-light table-hover table-responsive-md col-md-12 flex-md-grow-1"" id=""ispis"">
        <thead style=""height: 40px;"">
        <th>Id</th>
        <th>Naziv</th>
        </thead>
        <tbody id=""tbody"">
        </tbody>
    </table>

</div>
<script type=""text/javascript"">
    'use strict';
    function brisi(vrsta) {

        if (confirm('Jeste li sigurni da želite obrisati event?')) {
            var i = vrsta.parentNode.parentNode.rowIndex;
            var red = vrsta.parentNode.parentNode;
            var Id = red.firstChild.innerHTML;
            document.getElementById(""ispis"").deleteRow(i);
            axios.delete(`/api/admin/brisanjevrste/${Id}`, Id);
        }
    }
    function appendToTable(data) {
        console.log(data);
        for (var i = 0; i < data.length; i++) {
            let vrsta = data[i];
            CreateRow(vrsta.idVrsta, vrsta.naziv);
        }
    }
    function odustani() {
        let for");
            WriteLiteral(@"ma = document.getElementById(""podnesi"");
        forma.style.display = ""none"";
    }
    function timedRefresh(time) {
        setTimeout(""location.reload(true);"", time);
    }
    async function promijeniNaziv() {
        let promjenjenaVrsta = {
            ""IdVrsta"": parseInt(document.getElementById(""id"").value),
            ""naziv"": document.getElementById(""nazivVrste"").value
        }
        axios.put(""/api/admin/vrstaedit"", promjenjenaVrsta);
        timedRefresh(500);
    }
    function urediVrstu(id) {
        let forma = document.getElementById(""podnesi"");
        if (forma.style.display == ""none"") {
            forma.style.display = ""block"";
            document.getElementById(""id"").value = id;
        }
    }
    function CreateRow(id, naziv) {
        let tablica = document.getElementById('tbody');
        let row = tablica.insertRow();
        let stupac_id = row.insertCell();
        let stupac_naziv = row.insertCell();
        let stupac_uredi = row.insertCell();
   ");
            WriteLiteral(@"     let stupac_brisi = row.insertCell();
        stupac_id.innerHTML = id;
        stupac_naziv.innerHTML = naziv;
        stupac_uredi.innerHTML = `<button type=""button"" class=""btn btn-outline-dark btn-lg"" onclick=""urediVrstu(${id})"">Uredi</button>`;
        stupac_brisi.innerHTML = '<button type=""button"" class=""btn btn-outline-dark btn-lg"" onclick=""brisi(this)"">Briši</button>';
    }
    axios.get('/api/admin/svevrste').then(response => appendToTable(response.data))


</script>");
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
