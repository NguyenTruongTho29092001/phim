using NguyenTruongTho_1911066382_Tuan6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenTruongTho_1911066382_Tuan6.Models
{
    public class Giohang
    {
        MyDataDataContext data = new MyDataDataContext();

        [Display(Name = "Mã lịch chiếu")]
        public string malich { get; set; }

        [Display(Name = "Mã phim")]
        public int maphim { get; set; }


        [Display(Name = "Giá")]
        public Double gia { get; set; }
        [Display(Name = "Số lượng")]

        public int iSoluong { get; set; }
        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }
        [Display(Name = "Thành tiền")]
        public double dThanhtien { get { return iSoluong * gia; } }
        public Giohang(string malich)
        {
            this.malich = malich;
            LichChieu lich = data.LichChieus.Single(n => n.malich == malich);
            maphim = Convert.ToInt32(lich.maphim);
            iSoluong = Convert.ToInt32(lich.soluong);
            hinh = this.hinh;
            gia = double.Parse(lich.gia.ToString());
            iSoluong = 1;
        }
    }
}