using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class NhanVienPTN : Nhanvien
    {
        protected double luongThang;

        public NhanVienPTN(string hoTen, int namSinh, string bangCap, double luongThang) : base(hoTen, namSinh, bangCap)
        {
            this.luongThang = luongThang;
        }

        public NhanVienPTN() : base()
        {
            this.luongThang = 0;
        }

        public void Input()
        {
            base.Input();
            Console.Write("Luong thang: ");
            luongThang = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            base.Output();
            Console.Write(String.Format("{0, -10}", tinhLuong()));
        }

        public override double tinhLuong()
        {
            return luongThang;
        }
    }
}
