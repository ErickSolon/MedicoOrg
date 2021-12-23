// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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