using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JuegoOperaciones
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            

		}

        public void comenzar(Object sender, EventArgs e)
        {


                Navigation.PushModalAsync(new juego(Convert.ToInt32(numerointentos.SelectedItem)));


        }


    }
}
