#pragma checksum "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\StarWars\GetPlanetsById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9a97d71a327d5d8c72001b0ae7d2b3d620bd79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_GetPlanetsById), @"mvc.1.0.view", @"/Views/StarWars/GetPlanetsById.cshtml")]
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
#line 1 "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\_ViewImports.cshtml"
using Lab22StarWarsApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\_ViewImports.cshtml"
using Lab22StarWarsApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9a97d71a327d5d8c72001b0ae7d2b3d620bd79", @"/Views/StarWars/GetPlanetsById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3c3bb3244c5a0b2c8c1cc04095966dce5bd382", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_GetPlanetsById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlanetData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\StarWars\GetPlanetsById.cshtml"
  
    ViewData["Title"] = "GetPlanetsById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Star Wars Planets</h1>\r\n\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Population</th>\r\n        <th>Climate</th>\r\n        <th>Gravity</th>\r\n        <th>Terrain</th>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\StarWars\GetPlanetsById.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\StarWars\GetPlanetsById.cshtml"
       Write(Model.population);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\StarWars\GetPlanetsById.cshtml"
       Write(Model.climate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\StarWars\GetPlanetsById.cshtml"
       Write(Model.gravity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\Prophesy\Documents\C#2019\Lab22StarWarsApi\Lab22StarWarsApi\Views\StarWars\GetPlanetsById.cshtml"
       Write(Model.terrain);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlanetData> Html { get; private set; }
    }
}
#pragma warning restore 1591
