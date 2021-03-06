#pragma checksum "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58f395e5715bfe0bfeffd98bf193360423de1713"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorteste.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/pc/Desktop/blazorteste/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/pc/Desktop/blazorteste/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/pc/Desktop/blazorteste/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/pc/Desktop/blazorteste/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/pc/Desktop/blazorteste/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/pc/Desktop/blazorteste/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/pc/Desktop/blazorteste/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/pc/Desktop/blazorteste/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/pc/Desktop/blazorteste/_Imports.razor"
using blazorteste;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/pc/Desktop/blazorteste/_Imports.razor"
using blazorteste.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pessoas/list")]
    public partial class PessoasLista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><label>Consultas agendadas</label></h3>\n\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
              nomeInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nomeInput = __value, nomeInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "submit");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                                FiltrarPesssoasId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Filtrar por Id");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "submit");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                                FiltrarPessoasNome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Filtrar por nome");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "submit");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                                FiltrarPessoasSobrenome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Filtrar por Sobrenome");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "submit");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                                FiltrarPessoasTipoConsulta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Filtrar por Tipo de consulta");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "submit");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                                ReiniciarLista

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Reiniciar Lista");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n\n");
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "class", "table");
            __builder.AddMarkupContent(32, @"<thead><tr><th scope=""col"">Id</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Sobrenome</th>
            <th scope=""col"">Idade</th>
            <th scope=""col"">Tipo de consulta</th>
            <th scope=""col"">Hor??rio da consulta</th></tr></thead>
    ");
            __builder.OpenElement(33, "tbody");
#nullable restore
#line 24 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
         foreach (var item in pessoas)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "th");
            __builder.AddAttribute(36, "scope", "row");
            __builder.AddContent(37, 
#nullable restore
#line 27 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                                 item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 28 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                     item.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 29 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                     item.Sobrenome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 30 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                     item.Idade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 31 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                     item.TipoConsulta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 32 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
                     item.HorarioConsulta.ToString("dd/MM/yyyy hh:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/home/pc/Desktop/blazorteste/Pages/PessoasLista.razor"
       
    List<Pessoas> pessoas;
    List<Pessoas> pessoasSobrenome;

    List<Pessoas> pessoasLista => djPTDContext.Pessoas.ToList();

    string nomeInput = string.Empty;

    public void FiltrarPesssoasId()
    {
        if (!String.IsNullOrEmpty(nomeInput))
        {
            pessoas = djPTDContext.Pessoas.Where(x => x.Id == int.Parse(nomeInput)).ToList();
        }
    }

    public void FiltrarPessoasNome()
    {
        if (!String.IsNullOrEmpty(nomeInput))
        {
            pessoas = djPTDContext.Pessoas.Where(x => x.Nome == nomeInput).ToList();
        }
    }

    public void FiltrarPessoasSobrenome()
    {
        if (!String.IsNullOrEmpty(nomeInput))
        {
            pessoas = djPTDContext.Pessoas.Where(x => x.Sobrenome == nomeInput).ToList();
        }
    }

    public void FiltrarPessoasTipoConsulta()
    {
        if (!String.IsNullOrEmpty(nomeInput))
        {
            pessoas = djPTDContext.Pessoas.Where(x => x.TipoConsulta == nomeInput).ToList();
        }
    }

    public void ReiniciarLista()
    {
        pessoas = pessoasLista;
    }

    protected override void OnInitialized()
    {
        pessoas = pessoasLista;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private blazorteste.djangoProjectTesteDatabaseContext djPTDContext { get; set; }
    }
}
#pragma warning restore 1591
