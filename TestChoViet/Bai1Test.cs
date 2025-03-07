using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChoViet
{
    [TestFixture]
    class Bai1Test
    {
        Bai1Service _bai1;
        [SetUp]
        public void SetUp()
        {
            _bai1 = new Bai1Service();
        }
        [TestCase(new int[] {0},0)]
        [TestCase(new int[] { 0,1,2 }, 3)]
        [TestCase(new int[] { 0,-1,-2 }, -3)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { }, 0)]

        public void Tong(int[] mang, int ketQua)
        {
            Assert.That(_bai1.MangSoNguyen(mang), Is.EqualTo(ketQua));
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 8, 1, 2 }, 3)]
        [TestCase(new int[] { 16, 8, -1 }, 0)]
        [TestCase(new int[] { -1,-2 }, 0)]
        [TestCase(new int[] { 51,52}, 0)]
        public void Tong150KhongChia8(int[] mang, int ketQua)
        {
            Assert.That(_bai1.MangSoNguyenTu1Den50KhongChiaCHo8(mang), Is.EqualTo(ketQua));
        }
        [TearDown]
        public void TearDown()
        {
            _bai1 = null;
        }
    }
}
