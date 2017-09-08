using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinTestAgain
{
	public class Test3DPage : ContentPage
	{
		public Test3DPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin Forms!" }
				}
			};
		}
	}
}