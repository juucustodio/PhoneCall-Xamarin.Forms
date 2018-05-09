using System;
using Plugin.Messaging;
using Xamarin.Forms;

namespace DemoPhoneCall
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    public void Call(object sender, EventArgs e)
	    {
	        var phoneDialer = CrossMessaging.Current.PhoneDialer;
	        if (phoneDialer.CanMakePhoneCall && !String.IsNullOrWhiteSpace(Number.Text))
	            phoneDialer.MakePhoneCall(Number.Text);
        }
    }
}
