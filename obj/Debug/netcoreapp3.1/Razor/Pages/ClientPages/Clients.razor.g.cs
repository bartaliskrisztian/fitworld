#pragma checksum "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a16643256e83d0779d064a585ec8b7f23abe48b"
// <auto-generated/>
#pragma warning disable 1591
namespace FitnessProject.Pages.ClientPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients")]
    public partial class Clients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "addClient");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span>Add new\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h3>Clients</h3>");
#nullable restore
#line 9 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
 if(objClients == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<div>Loading...</div>");
#nullable restore
#line 12 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "clients-table");
            __builder.AddMarkupContent(10, @"<thead><tr><th>Client ID</th>
                <th>Name</th>
                <th>Phone number</th>
                <th>Email</th>
                <th>Address</th>
                <th>PIN</th>
                <th>Bar code</th>
                <th>Inserted date</th>
                <th>Is deleted</th></tr></thead>
        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 30 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
             foreach(var client in objClients)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 33 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.Client_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 34 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 35 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.Phone_number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 36 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 37 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 38 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.PIN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 39 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.Bar_code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 40 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.Inserted_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 41 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                     client.Is_deleted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "editClient/" + (
#nullable restore
#line 43 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                                                          client.Client_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Edit\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "class", "nav-link");
            __builder.AddAttribute(49, "href", "deleteClient/" + (
#nullable restore
#line 48 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
                                                            client.Client_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Delete\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\Clients.razor"
       
    List<Client> objClients;
    protected override async Task OnInitializedAsync()
    {
        objClients = await Task.Run(() => objClientService.GetClients());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientService objClientService { get; set; }
    }
}
#pragma warning restore 1591