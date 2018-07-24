using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HWorld
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnButtonClick(object sender, EventArgs args){
            if(HLabel.Text == "Hello"){
                HLabel.Text = "Goodbye";
            }
            else{
                HLabel.Text = "Hello";
            }


        }
	}
}
