#pragma checksum "C:\Users\47503773847\Documents\PROJETO FINAL - Ponto Digital\Views\Sac\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d6225e6dbeaad45fdc29750ad5afa51c9dffa11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sac_Index), @"mvc.1.0.view", @"/Views/Sac/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sac/Index.cshtml", typeof(AspNetCore.Views_Sac_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6225e6dbeaad45fdc29750ad5afa51c9dffa11", @"/Views/Sac/Index.cshtml")]
    public class Views_Sac_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\47503773847\Documents\PROJETO FINAL - Ponto Digital\Views\Sac\Index.cshtml"
  
    Html.RenderPartial("_HeaderNavBar");
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(74, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b662b7dc15c4d388f48019e3f38358c", async() => {
                BeginContext(80, 149, true);
                WriteLiteral(" \r\n    <link rel=\"stylesheet\" href=\"/css/sac.css\">\r\n    <link href=\"https://fonts.googleapis.com/css?family=PT+Sans&display=swap\" rel=\"stylesheet\">\r\n");
                EndContext();
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
            EndContext();
            BeginContext(236, 1777, true);
            WriteLiteral(@"

<html id=""letras"">
    <section id=""perguntas"">
        <h1>Como funciona Ponto Digital?</h1>
        </br>
        <p>O Ponto Digital funciona de um modo totalmente diferente de outros softwares e ""pontos"" que você vê por aí, ele funciona exatamente como um ""ponto"", mas, nossa grande diferença é que trabalhamos totalmente virtual e mais focado no ""home office"", estabelecendo metas diárias a seus funcionários para serem cumpridas dando várias possibilidades.</p>
        </br>
        </br>
        <h1>Como posso organizar as metas para meus funcionários?</h1>
        </br>
        <p>Essa parte de organizar as metas depende muito de seu modo de trabalho, mas irá ter uma aba de fácil acesso dentro do software focada em organizar melhor seus funcionário e suas metas.</p>
        </br>
        </br>
        <h1>O teste grátis pode ser adquirido de que forma?</h1>
        </br>
        <p>Nosso teste grátis pode ser adquirido em nossa aba de compras basta apenas criar sua conta e colocar os requ");
            WriteLiteral(@"isitos pedidos para conseguir o seu teste.</p>
        </br>
        </br>
        <h1>Como vou ter certeza que o meu funcionário irá cumprir as metas dele?</h1>
        </br>
        <p>Você saberá se ele cumpriu ou não suas metas, pois irá chegar uma notificação ao fim de seu expediente pedindo para ele confirmar as metas que foram pedidas para serem completadas até o fim do dia ou semana.</p>
        </br>
        </br>
        <h1>No caso de eu ser o funcionário como eu irei usar na minha casa?</h1>
        </br>
        <p>Irá usar de sua casa em um site ou aplicativo no celular de acordo com sua preferência, então com o software aberto irá trabalhar em seu horário estabelecido, cumprindo suas metas.</p>
    </section>
</html>");
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