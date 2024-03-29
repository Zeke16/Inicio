﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Categorias;
using Inicio.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inicio.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexMainPage : TabbedPage
    {
        public IndexMainPage ()
        {
            InitializeComponent();
        }

        private void BtnParqueA_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ParquesA());
        }

        private void BtnSitioA_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SitiosAr());
        }

        private void BtnPueblo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pueblos());

        }

        private void BtnParque_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Parques());

        }

        private void BtnPlaya_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Playas());

        }

        private void BtnBosque_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bosques());

        }
    }
}