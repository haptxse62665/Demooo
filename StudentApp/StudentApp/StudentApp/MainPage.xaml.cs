using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Pages;
using Xamarin.Forms;

namespace StudentApp
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            IsGestureEnabled = false;
        }

        private async void Button_Login(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomePage())
            {
                BarBackgroundColor = Color.FromHex("#FE3F3F"),
                BarTextColor = Color.White
            };
            IsPresented = false;
            IsGestureEnabled = true;

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
            IsGestureEnabled = true;

        }
        private void Button_Clickded4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ArrivalPage())
            {
                BarBackgroundColor = Color.FromHex("#47FD91"),
                BarTextColor = Color.White
            };
            IsPresented = false;
            IsGestureEnabled = true;
        }
    }
}
