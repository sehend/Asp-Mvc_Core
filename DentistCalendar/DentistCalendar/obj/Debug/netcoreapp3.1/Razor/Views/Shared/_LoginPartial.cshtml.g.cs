#pragma checksum "C:\Users\sehen\Desktop\DentistCalendar\DentistCalendar\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e37fd31e2168ccdf70fbc81704e2ba1680535fea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#line 1 "C:\Users\sehen\Desktop\DentistCalendar\DentistCalendar\Views\_ViewImports.cshtml"
using DentistCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sehen\Desktop\DentistCalendar\DentistCalendar\Views\_ViewImports.cshtml"
using Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sehen\Desktop\DentistCalendar\DentistCalendar\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37fd31e2168ccdf70fbc81704e2ba1680535fea", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6b6cb5d175d2c035e09084a348ca95cf18cacf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"navbar-nav\">\r\n");
#nullable restore
#line 4 "C:\Users\sehen\Desktop\DentistCalendar\DentistCalendar\Views\Shared\_LoginPartial.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a  class=\"nav-link text-dark\" href=\"/Profile/Index\" title=\"Manage\">Merhaba ");
#nullable restore
#line 7 "C:\Users\sehen\Desktop\DentistCalendar\DentistCalendar\Views\Shared\_LoginPartial.cshtml"
                                                                               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a href=\"/Account/LogOut\" class=\"nav-link btn btn-link text-dark\">Çıkış Yap</a>\r\n    </li>\r\n");
#nullable restore
#line 12 "C:\Users\sehen\Desktop\DentistCalendar\DentistCalendar\Views\Shared\_LoginPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a class=\"nav-link text-dark\" href=\"/Account/register\">Kayıt Ol</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a class=\"nav-link text-dark\" href=\"/Account/login\">Giriş Yap</a>\r\n    </li>\r\n");
#nullable restore
#line 21 "C:\Users\sehen\Desktop\DentistCalendar\DentistCalendar\Views\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
