using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChoViet
{
    [TestFixture]
    class SinhVienTest
    {
        SinhVienService service;
        [SetUp]
        public void SetUp()
        {
            service = new SinhVienService();
        }
        [Test]
        public void SuaThanhCong()
        {
            SinhVien sinhVien = new SinhVien("SV001", "Manh Viết", 12, 7, 5, "PTPM");
            Assert.That(service.SuaSinhVien("SV001", sinhVien), Is.EqualTo(true));
        }
        [Test]
        public void SuaTenTrong()
        {
            SinhVien sinhVien = new SinhVien("SV001", null, 12, 7, 5, "PTPM");
            Assert.Throws<ArgumentNullException>(() => service.SuaSinhVien("SV001", sinhVien));
        }
        [Test]
        public void SuaChuyenNganhTrong()
        {
            SinhVien sinhVien = new SinhVien("SV001", "Manh", 43, 7, 5, null);
            Assert.Throws<ArgumentNullException>(() => service.SuaSinhVien("SV001", sinhVien));
        }
        [Test]
        public void SuaTuoiNho0()
        {
            SinhVien sinhVien = new SinhVien("SV001", "Mạnh", -12, 7, 5, "PTPM");
            Assert.Throws<ArgumentNullException>(() => service.SuaSinhVien("SV001", sinhVien));
        }
        [Test]
        public void SuaDiemNho0()
        {
            SinhVien sinhVien = new SinhVien("SV001", "Manh", 12, -7, 5, "PTPM");
            Assert.Throws<ArgumentNullException>(() => service.SuaSinhVien("SV001", sinhVien));
        }
        [TearDown]
        public void TearDown()
        {
            service = null;
        }
    }
}
