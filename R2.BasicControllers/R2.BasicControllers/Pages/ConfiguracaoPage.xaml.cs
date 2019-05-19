using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace R2.BasicControllers.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfiguracaoPage : ContentPage
	{
		public ConfiguracaoPage ()
		{
			InitializeComponent ();
		}

        private void AceitarSwitchCell(object sender, ToggledEventArgs e)
        {
            SwitchCell sc = (SwitchCell)sender;
            bool switchCellState = sc.On;

            if (switchCellState)
                EmailEntry.IsVisible = true;
            else
            {
                EmailEntry.IsVisible = false;
                EmailEntry.Text = string.Empty;
            }
        }
    }
}