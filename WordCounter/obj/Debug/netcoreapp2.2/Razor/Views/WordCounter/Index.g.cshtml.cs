#pragma checksum "/Users/zsuzsannamangu/Desktop/Epicodus/WordCounter.Solution/WordCounter/Views/WordCounter/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d6db6c9c4b0ada41a8f49d3f098030374c5d426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WordCounter_Index), @"mvc.1.0.view", @"/Views/WordCounter/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WordCounter/Index.cshtml", typeof(AspNetCore.Views_WordCounter_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6db6c9c4b0ada41a8f49d3f098030374c5d426", @"/Views/WordCounter/Index.cshtml")]
    public class Views_WordCounter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zsuzsannamangu/Desktop/Epicodus/WordCounter.Solution/WordCounter/Views/WordCounter/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 42, true);
            WriteLiteral("<div class=\"text-center\">\n  <h1>The word \"");
            EndContext();
            BeginContext(70, 15, false);
#line 5 "/Users/zsuzsannamangu/Desktop/Epicodus/WordCounter.Solution/WordCounter/Views/WordCounter/Index.cshtml"
           Write(Model.GetWord());

#line default
#line hidden
            EndContext();
            BeginContext(85, 27, true);
            WriteLiteral("\" appears in your sentence ");
            EndContext();
            BeginContext(113, 55, false);
#line 5 "/Users/zsuzsannamangu/Desktop/Epicodus/WordCounter.Solution/WordCounter/Views/WordCounter/Index.cshtml"
                                                      Write(Model.WordCount(@Model.GetWord(), @Model.GetSentence()));

#line default
#line hidden
            EndContext();
            BeginContext(168, 142, true);
            WriteLiteral("x!</h1>\n  <br>\n  <button><a href=\'/wordcounter/new\'>Count a new word!</a></button>\n  <button><a href=\'/\'>Back to homepage</a></button>\n</div>\n");
            EndContext();
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
