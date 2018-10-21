using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : MasterDetailPage
	{
		public HomePage ()
		{
			InitializeComponent ();

		}
	    private void Button_Clicked(object sender, EventArgs e)
	    {
	        //Detail = new NavigationPage(new AddEmployee());
	        IsPresented = false;
	    }
	    private void Button_Clicked2(object sender, EventArgs e)
	    {
	        //Detail = new NavigationPage(new ListEmployee());
	        IsPresented = false;
	    }

	    private void Button_Clicked3(object sender, EventArgs e)
	    {
	        Detail = new NavigationPage(new EmergencyPage())
	        {
	            BarBackgroundColor = Color.FromHex("#FE3F3F"),
	            BarTextColor = Color.White
	        };
	        IsPresented = false;

	    }
	    private void Button_Clickded4(object sender, EventArgs e)
	    {
	        Detail = new NavigationPage(new ArrivalPage())
	        {
	            BarBackgroundColor = Color.FromHex("#47FD91"),
	            BarTextColor = Color.White
	        };
	        IsPresented = false;
	    }
    }
}