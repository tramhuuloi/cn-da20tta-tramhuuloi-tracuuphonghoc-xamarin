using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace doanchuyennganh
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class map : ContentPage
	{
		public map ()
		{
			InitializeComponent ();
		}
        public void SetPhonghoc(phonghoc phong)
        {
            BindingContext = phong;
        }
    }
}