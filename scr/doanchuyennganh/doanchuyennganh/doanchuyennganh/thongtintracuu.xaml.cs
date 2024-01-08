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
	public partial class thongtintracuu : ContentPage
	{
		public thongtintracuu ()
		{
			InitializeComponent ();
        }

        public void SetPhonghoc(phonghoc phong)
        {
            BindingContext = phong;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("SelectedPhong"))
            {
                // Lấy thông tin phòng đã chọn
                phonghoc selectedPhong = Application.Current.Properties["SelectedPhong"] as phonghoc;

                map mapPage = new map();

                // Gán dữ liệu
                mapPage.SetPhonghoc(selectedPhong);

                // Chuyển hướng
                await Navigation.PushAsync(mapPage);
            }
            else
            {
                await DisplayAlert("Thông báo", "Vui lòng tra cứu phòng trước khi xem thông tin", "OK");
            }
            
        }
    }
}