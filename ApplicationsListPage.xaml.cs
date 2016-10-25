using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StorefrontAPISample_Xamarin
{
	public partial class ApplicationsListPage : ContentPage
	{
		Classes.CitrixAuthCredential _auth = null;
		List<Classes.CitrixApplicationInfo> _resources = null;

		public ApplicationsListPage(Classes.CitrixAuthCredential AuthCredential, List<Classes.CitrixApplicationInfo> Resources)
		{
			InitializeComponent();

			this._auth = AuthCredential;
			this._resources = Resources;

			this.lstApplications.ItemsSource = this._resources;
		}



		void launchAppClicked(object sender, System.EventArgs e)
		{
			DisplayAlert("Not Implemented", "The code for launching an application has not been implemented in this sample", "OK");
		}
	}
}
