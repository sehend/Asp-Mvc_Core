#pragma checksum "C:\Users\sehen\Desktop\Jquert1\Jquert1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bd7635dd40fd45816e1ef859abe19347b666384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\sehen\Desktop\Jquert1\Jquert1\Views\_ViewImports.cshtml"
using Jquert1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sehen\Desktop\Jquert1\Jquert1\Views\_ViewImports.cshtml"
using Jquert1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd7635dd40fd45816e1ef859abe19347b666384", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e8e75b75905f2b1f3f1eb89c95bb60364f59eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sehen\Desktop\Jquert1\Jquert1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<p>Sehend</p>

<div id=""sina"">Sina</div>

<div class=""a"">Bariş</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bd7635dd40fd45816e1ef859abe19347b6663843619", async() => {
                WriteLiteral("\r\n\r\n    <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 344, "\"", 351, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Adınızı Giriniz\" /> <br /> <br />\r\n\r\n    <input type=\"password\" placeholder=\"Şifrenizi Giriniz\" />\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<li>1</li>

<li>2</li>

<li>3</li>

<li>4</li>

<li>5</li>

<li>6</li>

<div class=""sehend"">
    <p>ali</p>

    <p>hüseyin</p

    ><p>poyraz</p>

    <p>rüzgar</p>

    <b>kanarya</b>

</div>

<div class=""bir"">
    bir
</div>

<div class=""iki"">
    iki
</div>


<div class=""üç"">
    üç
</div>


<div class=""dört"">
    dört
</div>



<script>

    $(document).ready(function () {

        $('p').css('color', 'blue');

    });

    $(document).ready(function () {

        $('#sina').css('color', 'red');

    });

    $(document).ready(function () {

        $('.a').css('color', 'green');

    });



    $(document).ready(function (){

       
        $(""input:text"").css({ ""width"": ""600px"" })


    });

    $(document).ready(function (){

    //    $(""li:first"").css({ ""background-color"": ""green"" });

    ///*    tek sayıları seçmek için*/
    //    $(""li:odd"").css({ ""background-color"": ""green"" });
    ///*    çift sayıları seçmek");
            WriteLiteral(@" için*/
    //    $(""li:even"").css({ ""background-color"": ""green"" });

    //    $(""li:last"").css({ ""background-color"": ""green"" });


    });

    $(document).ready(function () {


        //$("".sehend p"").css({""background-color"" : ""red""});



        /*    $("".sehend p:first-child"").css({ ""background-color"": ""red"" });*/

        $("".sehend"").find(""b"").css({""background-color"" : ""red""});


    });

    $(document).ready(function () {



        $("".iki"").prev().css({""background-color"" : ""red""});

        $("".iki"").next().css({ ""background-color"": ""red"" });

    });



    $(document).ready(function () {



        $("" li:eq(6)"").css({ ""background-color"": ""red"" });



    });




    $(document).ready(function () {



        $("" li"").slice(7).css({ ""background-color"": ""red"" });


    });




</script>
");
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