using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StorefrontAPISample_Xamarin
{
	public partial class LoginPage : ContentPage
	{
		async void Login_Clicked(object sender, System.EventArgs e)
		{
			string _username = txtUsername.Text.Trim();
			string _password = txtPassword.Text;
			string _domain = txtDomain.Text.Trim();
			string _sfUrl = txtSFUrl.Text.Trim();
			Classes.CitrixAuthCredential _authToken = await Classes.CitrixHelper.Storefront.AuthenticateWithPost(_sfUrl,
																 _username,
																 _password,
																 _domain);

			if (_authToken == null)
			{
				//was not able to authenticate
				DisplayAlert("Login Error", "Unable to authenticate to StoreFront", "OK");
			}
			else
			{
				List<Classes.CitrixApplicationInfo> _resources = await Classes.CitrixHelper.Storefront.GetResourcesFromStoreFront(_sfUrl,
														 _authToken,
														 false);
				foreach (var _resource in _resources)
				{
					_resource.AppIcon = await Classes.CitrixHelper.Storefront.GetImage(_sfUrl, _resource);
					_resource.Auth = _authToken;
					_resource.StorefrontURL = _sfUrl;
				}
				//App.Current.MainPage = new NavigationPage(new ICAViewer("TESTING"));
				App.Current.MainPage = new NavigationPage(new ApplicationsListPage(_authToken, _resources));
			}
		}

		public LoginPage()
		{
			InitializeComponent();
		}
	}
}
