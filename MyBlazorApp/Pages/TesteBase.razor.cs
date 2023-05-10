using Microsoft.AspNetCore.Components;

namespace MyBlazorApp.Pages
{
    public class TesteBase :ComponentBase
    {
        public bool Exibir = false;
        protected string Texto = string.Empty;

        public void Clicou()
        {
            Exibir = !Exibir;
        }
    }
}
