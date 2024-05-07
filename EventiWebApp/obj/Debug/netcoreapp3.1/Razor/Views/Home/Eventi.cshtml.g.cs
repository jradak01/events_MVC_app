#pragma checksum "C:\Users\jopy_\OneDrive\Desktop\PMA_Eventi_JospiaRadak\EventiWebApp\EventiWebApp\Views\Home\Eventi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be5446bc5a9ed0105fdfa43f065e3f67b0952f30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Eventi), @"mvc.1.0.view", @"/Views/Home/Eventi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be5446bc5a9ed0105fdfa43f065e3f67b0952f30", @"/Views/Home/Eventi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba2c780577e12b7ece9d61237c7539af65388d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Eventi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""table-responsive-sm"">
    <table class=""table-light table-hover table-responsive-md col-md-12 flex-md-grow-1"" id=""ispis"">
        <thead style=""height: 40px;"">
        <th>Naziv</th>
        <th>Vrijeme</th>
        <th>Mjesto</th>
        <th>Adresa</th>
        <th>Cijena</th>
        <th>Ograniceni Posjetitelji</th>
        <th>Vrsta Eventa</th>
        <th>Organizator</th>
        </thead>
        <tbody id=""tbody"">
        </tbody>
    </table>
</div>
<script type=""text/javascript"">
    'use strict';
    function appendToTable(data) {
        console.log(data);
        for (var i = 0; i < data.length; i++) {
            let event_ = data[i];
            console.log(event_);
            CreateRow(event_.naziv, event_.vrijeme, event_.mjesto, event_.adresa, event_.cijena, event_.ograniceniPosjetitelji, event_.vrstaEventa, event_.organizator);
        }
    }
    function insertIntoCell(cell, data) {
        cell.innerHTML = data.naziv;
    }
    function insertInto");
            WriteLiteral(@"CellOrg(cell, data) {
        cell.innerHTML = data.korisnickoIme;
    }
    function CreateRow(naziv, vrijeme, mjesto, adresa, cijena, ograniceniPosjetitelji, vrstaEventa, organizator) {
        let tablica = document.getElementById('tbody');
        let row = tablica.insertRow();
        let stupac_naziv = row.insertCell();
        let stupac_vrijeme = row.insertCell();
        let stupac_mjesto = row.insertCell();
        let stupac_adresa = row.insertCell();
        let stupac_cijena = row.insertCell();
        let stupac_ograniceniPosjetitelji = row.insertCell();
        let stupac_vrstaEventa = row.insertCell();
        let stupac_organizator = row.insertCell();

        let ogr;
        if (ograniceniPosjetitelji == true) { ogr = ""DA""; }
        else { ogr = ""NE"";}

        stupac_naziv.innerHTML = naziv;
        stupac_vrijeme.innerHTML = vrijeme;
        axios.get(`/api/korisnik/mjesto/${mjesto}`, mjesto).then(resolve => insertIntoCell(stupac_mjesto, resolve.data))
        stupa");
            WriteLiteral(@"c_adresa.innerHTML = adresa;
        stupac_cijena.innerHTML = cijena;
        axios.get(`/api/korisnik/vrsta/${vrstaEventa}`, vrstaEventa).then(resolve => insertIntoCell(stupac_vrstaEventa, resolve.data))
        stupac_ograniceniPosjetitelji.innerHTML = ogr;
        axios.get(`/api/korisnik/korisnik/${organizator}`, organizator).then(resolve => insertIntoCellOrg(stupac_organizator, resolve.data))
    }
    axios.get('/api/korisnik').then(response => appendToTable(response.data))
    axios.get('/api/korisnik/svamjesta').then(response => appendToSelect(response.data))
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