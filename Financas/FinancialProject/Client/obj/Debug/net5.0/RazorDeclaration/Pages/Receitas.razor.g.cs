// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinancialProject.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using FinancialProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\_Imports.razor"
using FinancialProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\Pages\Receitas.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\Pages\Receitas.razor"
using FinancialProject.Client.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/receitas")]
    public partial class Receitas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\inetpub\wwwroot1\yann\programas\Financas\Financas1\FinancialProject\Client\Pages\Receitas.razor"
       
    private Receita[] receitas;
    protected async override Task OnInitializedAsync()
    {
        await CarregaDados();
    }

    protected async Task CarregaDados()
    {
        receitas = await Http.GetFromJsonAsync<Receita[]>("api/Receitas");
        StateHasChanged();
    }

    public async Task Refresh()
    {
        await CarregaDados();
    }   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
