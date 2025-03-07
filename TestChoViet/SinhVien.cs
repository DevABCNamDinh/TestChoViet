using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChoViet
{
    class SinhVien
    {
        public SinhVien(string ma, string ten, int tuoi, float diemTrungBinh, int hocKy, string chuyenNganh)
        {
            this.ma = ma;
            this.ten = ten;
            this.tuoi = tuoi;
            this.diemTrungBinh = diemTrungBinh;
            this.hocKy = hocKy;
            this.chuyenNganh = chuyenNganh;
        }

        public string ma { get; set; }
        public string ten { get; set; }
        public int tuoi { get; set; }
        public float diemTrungBinh { get; set; }
        public int hocKy { get; set; }
        public string chuyenNganh { get; set; }
    }
}
