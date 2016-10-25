using System;
using System.Windows.Input;

namespace StorefrontAPISample_Xamarin
{
	public class ShowICACommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public async void Execute(object parameter)
		{
			Classes.CitrixApplicationInfo _appInfo = (Classes.CitrixApplicationInfo)parameter;

			string _icaString = await Classes.CitrixHelper.Storefront.RetreiveICA(_appInfo.StorefrontURL, _appInfo.Auth, _appInfo);

			App.Current.MainPage.Navigation.PushAsync(new ICAViewer(_icaString));
		}

	}
}
