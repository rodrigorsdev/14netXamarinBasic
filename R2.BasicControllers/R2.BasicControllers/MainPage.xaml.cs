using System;
using Xamarin.Forms;

namespace R2.BasicControllers
{
    public partial class MainPage : ContentPage
    {
        private ViewModels.ConfiguracaoViewModel _configuracaoViewModel;

        public MainPage()
        {
            if (_configuracaoViewModel == null)
                _configuracaoViewModel = new ViewModels.ConfiguracaoViewModel();

            InitializeComponent();
        }

        private void EnviarClicked(object sender, EventArgs e)
        {
            if (_configuracaoViewModel.EnviarEmail)
                DisplayAlert("Mensagem", $"E-mail enviado para {_configuracaoViewModel.Email}", "OK");
            else
                DisplayAlert("Mensagem", $"E-mail não autorizado!", "OK");
        }

        private void ConfiguracaoClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.ConfiguracaoPage() { BindingContext = _configuracaoViewModel });
        }
    }
}
