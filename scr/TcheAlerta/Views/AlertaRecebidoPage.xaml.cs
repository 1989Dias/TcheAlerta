using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcheAlerta.ViewModels;
using TcheAlerta.ViewModels.Alertas;
using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace TcheAlerta.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertaRecebidoPage : ContentPage
    {
        private readonly IPaginaServico _paginaServico;

        public AlertaRecebidoPage() {
            _paginaServico = new PaginaServico();
            InitializeComponent();
        }

        public AlertaRecebidoPage(string IdAlerta) {           
            InitializeComponent();
            BindingContext = new AlertaViewModel(IdAlerta);
        }
       
    }
}