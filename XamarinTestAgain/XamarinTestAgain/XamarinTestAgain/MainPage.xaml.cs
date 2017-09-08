using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTestAgain
{
   public partial class MainPage : ContentPage
   {
      public string TestText { get; set; }
      public List<string> Items1 { get; set; }
      public List<string> Items2 { get; set; }
      public List<string> Items3 { get; set; }

      public MainPage()
      {
         TestText = "Yup this is Brett test!";
         Items1 = new List<string>() { "Hey", "Brett Lesnau" };
         Items2 = new List<string>() { "You" };
         Items3 = new List<string>() { "Uhhh", "Nope", "Gee Whiz" };
         this.BindingContext = this;
         InitializeComponent();
      }
   }
}
