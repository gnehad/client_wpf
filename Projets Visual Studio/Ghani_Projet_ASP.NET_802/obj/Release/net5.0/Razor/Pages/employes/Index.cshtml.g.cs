#pragma checksum "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "702314cf364cb539108c4131bf59146dc6bf3561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ghani_Projet_ASP.NET_802.Pages.employes.Pages_employes_Index), @"mvc.1.0.razor-page", @"/Pages/employes/Index.cshtml")]
namespace Ghani_Projet_ASP.NET_802.Pages.employes
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
#line 1 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\_ViewImports.cshtml"
using Ghani_Projet_ASP.NET_802;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"702314cf364cb539108c4131bf59146dc6bf3561", @"/Pages/employes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc88ead90888e3b2ff22147b8b9a64a9136f7fa", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_employes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702314cf364cb539108c4131bf59146dc6bf35614698", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].DateDeNaissance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].DateEmbauche));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Adresse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].CodePostal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Pays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Extension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employes[0].Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
 foreach (var item in Model.Employes) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateDeNaissance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateEmbauche));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Adresse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodePostal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Extension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702314cf364cb539108c4131bf59146dc6bf356115912", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
                                       WriteLiteral(item.EmployeID);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702314cf364cb539108c4131bf59146dc6bf356118158", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
                                          WriteLiteral(item.EmployeID);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702314cf364cb539108c4131bf59146dc6bf356120410", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
                                         WriteLiteral(item.EmployeID);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 100 "C:\Cours AEC\Session 5\Projets Github\Projets formation\Gestion des clients et commandes en WPF et EF\Ghani_Projet_ASP.NET_802\Pages\employes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ghani_Projet_ASP.NET_802.Pages.employes.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ghani_Projet_ASP.NET_802.Pages.employes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ghani_Projet_ASP.NET_802.Pages.employes.IndexModel>)PageContext?.ViewData;
        public Ghani_Projet_ASP.NET_802.Pages.employes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
