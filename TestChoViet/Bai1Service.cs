using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChoViet
{
    class Bai1Service
    {
        public int MangSoNguyen(int[] mangSo)
        {
            return mangSo.Sum();
        }
        public int MangSoNguyenTu1Den50KhongChiaCHo8(int[] mangSo)
        {
            return mangSo.Where(x=>x%8!=0&&x>0&&x<=50).Sum();
        }
    }
}
