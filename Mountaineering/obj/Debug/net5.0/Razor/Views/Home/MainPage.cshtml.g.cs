#pragma checksum "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff7de24042f6f3b4e425870c7acf48f2e96d5ffc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MainPage), @"mvc.1.0.view", @"/Views/Home/MainPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7de24042f6f3b4e425870c7acf48f2e96d5ffc", @"/Views/Home/MainPage.cshtml")]
    public class Views_Home_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mountaineering.Models.ViewModels.ViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff7de24042f6f3b4e425870c7acf48f2e96d5ffc2795", async() => {
                WriteLiteral("\r\n    <title>Main Page</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff7de24042f6f3b4e425870c7acf48f2e96d5ffc3793", async() => {
                WriteLiteral(@"
    <h1>Mountaineering</h1><hr />

    <h2>Climbers overview</h2>
    <table>
        <tr>
            <th>Name</th>
            <th>Nationality</th>
            <th>Mountain</th>
            <th>Altitude</th>
            <th>Injured</th>
        </tr>
");
#nullable restore
#line 18 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
         if (Model.ClimbersVM != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
             foreach (var item in Model.ClimbersVM)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
                   Write(item.Climbers_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
                   Write(item.Nationality);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 680, "\"", 687, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
                              Write(item.Mountain.Mountain_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
                   Write(item.Altitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
                   Write(item.IsInjured);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        Else\r\n        {\r\n            <tr>No climbers in list</tr>\r\n        }\r\n    </table><hr />\r\n\r\n    <h2>Climb a mountain</h2>\r\n    <form");
                BeginWriteAttribute("action", " action=\"", 1008, "\"", 1017, 0);
                EndWriteAttribute();
                BeginWriteAttribute("method", " method=\"", 1018, "\"", 1027, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <label for=\"climber\">Climber:</label><br />\r\n        <select id=\"climber\" name=\"climber\">\r\n");
#nullable restore
#line 41 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
             foreach (var item in Model.ClimbersVM.Where(a => a.IsInjured == false))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <option>");
#nullable restore
#line 43 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
                   Write(item.Climbers_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 44 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </select><br />

        <label for=""distance"">Distance:</label><br />
        <input type=""number"" min=""0"" max=""8850"" step=""50"" placeholder=""Height in meters"" /><br />

        <input type=""submit"" value=""Submit"" />
    </form><hr />

    <h2>Add new climber</h2>
    <form");
                BeginWriteAttribute("action", " action=\"", 1591, "\"", 1600, 0);
                EndWriteAttribute();
                BeginWriteAttribute("method", " method=\"", 1601, "\"", 1610, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        <label for=""name"">Name:</label><br />
        <input type=""text"" id=""name"" name=""name"" placeholder=""Name"" /><br />

        <label for=""nationality"">Nationality:</label><br />
        <input type=""text"" id=""nationality"" name=""nationality"" placeholder=""Nationality"" /><br />

        <label for=""mountain"">Mountain:</label><br />
        <select id=""mountain"" name=""mountain"">
");
#nullable restore
#line 63 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
             foreach (var item in Model.MountainsVM)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <option>");
#nullable restore
#line 65 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
                   Write(item.Mountain_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 66 "C:\Users\micha\greenfox\canaIdeals-orientation-retake-exam\Mountaineering\Views\Home\MainPage.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select><br />\r\n\r\n        <input type=\"submit\" value=\"Submit\" />\r\n    </form>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mountaineering.Models.ViewModels.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591