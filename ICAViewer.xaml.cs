using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StorefrontAPISample_Xamarin
{
	public partial class ICAViewer : ContentPage
	{
		public ICAViewer(string ICAFileContents)
		{
			InitializeComponent();

			this.txtICA.Text = ICAFileContents;
		}
	}
}
