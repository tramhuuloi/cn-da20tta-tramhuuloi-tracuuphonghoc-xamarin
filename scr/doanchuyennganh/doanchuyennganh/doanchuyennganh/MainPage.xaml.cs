using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace doanchuyennganh
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Lấy mã phòng từ En
            string maPhongCanTim = txtMaPhong.Text;

            // Tìm phòng
            phonghoc phongCanTim = phonghoc.GetPhonghocs().FirstOrDefault(p => p.MaPhong == maPhongCanTim);

            if (phongCanTim != null)
            {
                // Hiển thị tên và hình ảnh trên MainPage
                txtname.Text = phongCanTim.MaPhong;

                // Lưu thông tin phòng
                Application.Current.Properties["SelectedPhong"] = phongCanTim;
            }
            else
            {
                await DisplayAlert("Thông báo", "Không tìm thấy phòng học", "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("SelectedPhong"))
            {
                // Lấy thông tin phòng đã chọn
                phonghoc selectedPhong = Application.Current.Properties["SelectedPhong"] as phonghoc;

                thongtintracuu thongTinPage = new thongtintracuu();

                // Gán dữ liệu
                thongTinPage.SetPhonghoc(selectedPhong);

                // Chuyển hướng
                await Navigation.PushAsync(thongTinPage);
            }
            else
            {
                await DisplayAlert("Thông báo", "Vui lòng tra cứu phòng trước khi xem thông tin", "OK");
            }

        }

        public class MainPageViewModel
        {
            public List<phonghoc> Collection { get; set; }

            public MainPageViewModel()
            {
                Collection = phonghoc.GetPhonghocs();
            }
        }
    }
}
