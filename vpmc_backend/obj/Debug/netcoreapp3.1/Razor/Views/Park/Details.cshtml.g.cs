#pragma checksum "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "767c8b952400703773fd5b9dec6dcc7e9b257724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Park_Details), @"mvc.1.0.view", @"/Views/Park/Details.cshtml")]
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
#line 1 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\_ViewImports.cshtml"
using vpmc_backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\_ViewImports.cshtml"
using vpmc_backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767c8b952400703773fd5b9dec6dcc7e9b257724", @"/Views/Park/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d85d08ed9418638ef3ab2a39b8343736a9918c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Park_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vpmc_backend.Models.ParkSurveyDataSheet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_EmptyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ParkSurveyDataSheet</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AssetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.AssetType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandMarkCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandMarkCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandMarkVillage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandMarkVillage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandMarkName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandMarkName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandMarkCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandMarkCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildMarkCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildMarkCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildMarkVillage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildMarkVillage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildMarkName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildMarkName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildMarkCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildMarkCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildAddressCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildAddressCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildAddressVillage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildAddressVillage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ParkArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.ParkArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ParkType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.ParkType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ParkMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.ParkMethod.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandRightsOwner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandRightsOwner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandRightsStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandRightsStatus.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandRightsHolding));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandRightsHolding));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingRightsOwner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingRightsOwner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingRightsStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingRightsStatus.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingRightsHolding));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingRightsHolding));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherRights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.OtherRights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AssignMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.AssignMethod.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandUses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandUses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingCoverageRatio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingCoverageRatio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FloorAreaRatio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.FloorAreaRatio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingUsage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingUsage.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingStructure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingStructure.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingFinishDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingFinishDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingUpFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingUpFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingDownFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 204 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingDownFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 207 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 210 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 213 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ParkWidth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 216 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.ParkWidth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 219 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ParkHeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 222 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.ParkHeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 225 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AllowSuv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 228 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.AllowSuv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 231 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InspectionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 234 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.InspectionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 237 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValueOpinionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 240 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValueOpinionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 243 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppraisalObject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 246 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppraisalObject.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 249 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppraisalDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 252 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppraisalDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 255 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PriceType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 258 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.PriceType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 261 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EvaluationRightsType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 264 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.EvaluationRightsType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 267 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppraisalCondition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 270 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppraisalCondition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 273 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 276 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 279 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 282 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 285 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TranscriptPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 288 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.TranscriptPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 291 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 294 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "767c8b952400703773fd5b9dec6dcc7e9b25772435801", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 299 "C:\Users\r1111\Source\Repos\vpmc_backend_clean_2\vpmc_backend\Views\Park\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "767c8b952400703773fd5b9dec6dcc7e9b25772437953", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vpmc_backend.Models.ParkSurveyDataSheet> Html { get; private set; }
    }
}
#pragma warning restore 1591
