using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace MyBlazorApp.Pages
{
    public class TesteBase :ComponentBase
    {
        public bool Exibir = false;
        protected string Texto = string.Empty;

        [Inject]
        public IJSRuntime Js { get; set; }

        [Parameter]
        public int Id { get; set; }
        public void Clicou()
        {
            Exibir = !Exibir;
        }

		protected override async void OnAfterRender(bool firstRender)
		{
			base.OnAfterRender(firstRender);
			//await Js.InvokeVoidAsync("window.alert", "Esta mensagem foi definida no C# !");
		}

        protected void Atualizar()
        {
            StateHasChanged();
        }

        private string Chave = "MeuApp";
        protected async Task Gravar()
        {
            await Js.InvokeVoidAsync("window.localStorage.setItem", Chave, Texto);
        }

        protected async Task Ler()
        {
            await Js.InvokeVoidAsync("alert", await Js.InvokeAsync<string>("window.localStorage.getItem", Chave));
        }

        protected async void Remover()
        {
			await Js.InvokeVoidAsync("window.localStorage.removeItem", Chave);
		}
     }
}
