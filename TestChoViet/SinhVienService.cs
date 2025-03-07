using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChoViet
{
    class SinhVienService
    {
        List<SinhVien> sinhViens = new List<SinhVien>
        {
            new SinhVien ("SV001","Manh",12,7,5,"PTPM")
        };
        public bool SuaSinhVien(string ma, SinhVien sinhVien)
        {
            if (sinhVien.ma==null|| sinhVien.ten == null || sinhVien.tuoi == null 
                || sinhVien.diemTrungBinh == null || sinhVien.hocKy == null
                || sinhVien.chuyenNganh == null || sinhVien.tuoi <= 0 || sinhVien.diemTrungBinh <= 0)
            {
                throw new ArgumentNullException("Có trường trống");
            }
            var sinhVienEdit = sinhViens.FirstOrDefault(x => x.ma == ma);
            if (sinhVienEdit == null) throw new ArgumentNullException("Khong thay sinh vien");
            sinhVienEdit.ma = sinhVien.ma;
            sinhVienEdit.ten = sinhVien.ten;
            sinhVienEdit.tuoi = sinhVien.tuoi;
            sinhVienEdit.diemTrungBinh = sinhVien.diemTrungBinh;
            sinhVienEdit.hocKy = sinhVien.hocKy;
            sinhVienEdit.chuyenNganh = sinhVien.chuyenNganh;
            return true;

        }
    }
}
