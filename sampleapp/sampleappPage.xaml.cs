using System;
using Xamarin.Forms;

namespace sampleapp
{
	public partial class sampleappPage : ContentPage
	{
		public sampleappPage()
		{			
			InitializeComponent();
					
		}

		public void OnClicked(object sender, EventArgs e)
		{ 
		DisplayAlert("JenkinsDemo", "Welcome to Jenkins with Xamarin", "OK");
		}
	}
}

