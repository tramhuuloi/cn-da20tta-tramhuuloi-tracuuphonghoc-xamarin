using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace doanchuyennganh
{
    public class phonghoc
    {
        public string MaPhong { get; set; }
        public string Khu { get; set; }
        public string ToaNha { get; set; }
        public string Lau { get; set; }
        public string ThongTin { get; set; }
        public string Image { get; set; }
        public string ImageMap { get; set; }
        public ImageSource AnhSource => ImageSource.FromFile(Image);
        public ImageSource AnhMapSource => ImageSource.FromFile(ImageMap);

        public static List<phonghoc> GetPhonghocs()
        {
            return new List<phonghoc>()
                 {
                    new phonghoc() { MaPhong = "A1", Khu = "1", ToaNha = "A1", Lau = "---", ThongTin = "Phòng công tác sinh viên, phòng đào tạo", Image = "A1.jpg", ImageMap = "mapA1.jpg" },
                    new phonghoc() { MaPhong = "B1", Khu = "1", ToaNha = "B1", Lau = "---", ThongTin = "Khoa kinh tế", Image = "B1.jpg", ImageMap = "mapB1.jpg"},
                    new phonghoc() { MaPhong = "B5", Khu = "1", ToaNha = "B5", Lau = "---", ThongTin = "Khoa nông nghiệp thủy sản", Image = "B5.jpg", ImageMap = "mapB5.jpg"},
                    new phonghoc() { MaPhong = "B7", Khu = "1", ToaNha = "B7", Lau = "---", ThongTin = "Thư viện", Image = "B7.jpg", ImageMap = "mapB7.jpg"},
                    new phonghoc() { MaPhong = "C1", Khu = "1", ToaNha = "C1", Lau = "---", ThongTin = "Khoa Y - Dược ", Image = "C1.jpg", ImageMap = "mapC1.jpg"},
                    new phonghoc() { MaPhong = "C7", Khu = "1", ToaNha = "C7", Lau = "---", ThongTin = "Bộ môn công nghệ thông tin", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "D5", Khu = "1", ToaNha = "D5", Lau = "---", ThongTin = "Hội trường", Image = "D5.jpg", ImageMap = "mapD5.jpg"},
                    new phonghoc() { MaPhong = "D7", Khu = "1", ToaNha = "D7", Lau = "---", ThongTin = "Khu vực phòng máy tính, thi trắc nghiệm", Image = "D7.jpg", ImageMap = "mapD7.jpg"},

                    new phonghoc() { MaPhong = "C71.101", Khu = "1", ToaNha = "C7", Lau = "1", ThongTin = "Phòng giảng viên", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.102", Khu = "1", ToaNha = "C7", Lau = "1", ThongTin = "Phòng giảng viên 2", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.103", Khu = "1", ToaNha = "C7", Lau = "1", ThongTin = "Phòng giảng viên 3", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.104", Khu = "1", ToaNha = "C7", Lau = "1", ThongTin = "Phòng giảng viên 4", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.105", Khu = "1", ToaNha = "C7", Lau = "1", ThongTin = "Phòng giảng viên 5", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.201", Khu = "1", ToaNha = "C7", Lau = "2", ThongTin = "Phòng giảng viên", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.202", Khu = "1", ToaNha = "C7", Lau = "2", ThongTin = "Phòng họp", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.203", Khu = "1", ToaNha = "C7", Lau = "2", ThongTin = "Phòng giảng viên", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.204", Khu = "1", ToaNha = "C7", Lau = "2", ThongTin = "Phòng máy tính 1", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.205", Khu = "1", ToaNha = "C7", Lau = "2", ThongTin = "Phòng máy tính 2", Image = "C7.jpg", ImageMap = "mapC7.jpg"},
                    new phonghoc() { MaPhong = "C71.206", Khu = "1", ToaNha = "C7", Lau = "2", ThongTin = "Phòng máy tính 3", Image = "C7.jpg", ImageMap = "mapC7.jpg"},


                    new phonghoc() { MaPhong = "D71.101", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng giảng viên", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.102", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 1", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.103", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 2", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.104", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 3", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.105", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 4", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.106", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 5", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.107", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 6", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.108", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 7", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.109", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 8", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.110", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 9", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.111", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 10", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.112", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 11", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.113", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 12", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.114", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 13", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.115", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 14", Image = "D7.jpg", ImageMap = "mapD7.jpg"},
                    new phonghoc() { MaPhong = "D71.116", Khu = "1", ToaNha = "D7", Lau = "1", ThongTin = "Phòng máy tính 15", Image = "D7.jpg", ImageMap = "mapD7.jpg"},

                 };
        }
    }
}
