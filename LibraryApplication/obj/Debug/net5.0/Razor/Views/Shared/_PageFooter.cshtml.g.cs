#pragma checksum "E:\projects\LibraryApplication\LibraryApplication\Views\Shared\_PageFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d9853c0bc4ee24f593ca9c319d495e559a2135a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PageFooter), @"mvc.1.0.view", @"/Views/Shared/_PageFooter.cshtml")]
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
#line 1 "E:\projects\LibraryApplication\LibraryApplication\Views\_ViewImports.cshtml"
using LibraryApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projects\LibraryApplication\LibraryApplication\Views\_ViewImports.cshtml"
using LibraryApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9853c0bc4ee24f593ca9c319d495e559a2135a", @"/Views/Shared/_PageFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3360be52740a86a64ec778a064c7e4b88e719a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PageFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"main-footer\">\r\n    ");
#nullable restore
#line 2 "E:\projects\LibraryApplication\LibraryApplication\Views\Shared\_PageFooter.cshtml"
Write(Model.Copyright);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</footer>");
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
