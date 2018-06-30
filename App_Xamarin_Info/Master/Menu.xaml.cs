using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App_Xamarin_Info.Master
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoPaginaPerfil1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Perfil1());
            IsPresented = false;
        }

        private void GoPaginaXamarin(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;
        }
    }
}
