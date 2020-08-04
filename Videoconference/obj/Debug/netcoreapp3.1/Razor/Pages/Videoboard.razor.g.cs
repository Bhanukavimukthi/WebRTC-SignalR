#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "213e29a96b8c9aa32b4476679df9e0fbf2f3dcf0"
// <auto-generated/>
#pragma warning disable 1591
namespace Videoconference.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Videoconference;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Videoconference.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Videoconference.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\_Imports.razor"
using Videoconference.Hubs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class Videoboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "connected-users");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3>Group state</h3>\r\n    ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "list-unstyled");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor"
         foreach (string message in groupMessages)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "li");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor"
                 message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "videos");
            __builder.AddMarkupContent(16, "\r\n    <video id=\"localVideo\" autoplay muted style=\"border: 8px solid red\"></video>\r\n    <video id=\"remoteVideo\" autoplay style=\"border: 8px solid yellow\"></video>\r\n    <br>\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "id", "start");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor"
                                               Call

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Start Video");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.OpenElement(23, "nav");
            __builder.AddAttribute(24, "class", "navbar fixed-bottom navbar-dark bg-dark toolbarSignalR");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<h3 class=\"navbar-brand\">State</h3>\r\n        ");
            __builder.OpenElement(27, "ul");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "li");
            __builder.AddContent(30, "Connection State: ");
            __builder.OpenElement(31, "span");
            __builder.AddContent(32, 
#nullable restore
#line 28 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor"
                                         HubConnection.State

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "li");
            __builder.AddContent(35, "Connection ID: ");
            __builder.OpenElement(36, "span");
            __builder.AddContent(37, 
#nullable restore
#line 29 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor"
                                      HubConnection.ConnectionId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Gautier\source\repos\KarmaFlights\Videoconference\Videoconference\Pages\Videoboard.razor"
       
    [CascadingParameter]
    public string RoomId { get; set; }

    HubConnection HubConnection;
    List<string> groupMessages = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        await InitializeAndAddToHubAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("invoke_initWebRTC", RoomId);
    }

    async Task InitializeAndAddToHubAsync()
    {
        // Connection creation
        HubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/webRTCHub"))
            .Build();

        HubConnection.On<string>("SendMessageToGroup", message => UpdateMessageGroup(message));
        HubConnection.On<string>("OfferReceived", offer => OnReceiveOffer(offer));
        HubConnection.On<string>("AnswerReceived", async answer => { UpdateMessageGroup("ta mere"); await JSRuntime.InvokeVoidAsync("invoke_onReceiveAnswer", answer); });

        // Connection start
        await HubConnection.StartAsync();

        // Adding the connection id to the group
        await HubConnection.SendAsync("AddToGroup", HubConnection.ConnectionId, RoomId);
    }

    void UpdateMessageGroup(string message)
    {
        groupMessages.Add(message);
        StateHasChanged();
    }

    async Task Call()
    {
        string offer = await JSRuntime.InvokeAsync<string>("invoke_createOffer");
        await HubConnection.SendAsync("SendOffer", offer, RoomId);
    }

    async Task OnReceiveOffer(string offer)
    {
        string answer = await JSRuntime.InvokeAsync<string>("invoke_onReceiveOffer", offer);
        await HubConnection.SendAsync("SendAnswer", answer, RoomId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
