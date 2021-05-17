using TcheAlerta.ViewModels.Alertas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TcheAlerta.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoAlertaPage : ContentPage {
        AlertaViewModel viewModel;

        public NovoAlertaPage() {
            viewModel = new AlertaViewModel();
            BindingContext = new AlertaViewModel();
           
            InitializeComponent();            
        }
    }
}