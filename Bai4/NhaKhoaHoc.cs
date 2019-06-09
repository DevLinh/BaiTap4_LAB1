using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class NhaKhoaHoc : Nhanvien
    {
        protected string chucVu;
        protected int soBaiBao;
        protected int soNgayCong;
        protected float bacLuong;

        public NhaKhoaHoc(string hoTen, int namSinh, string bangCap, string chucVu, int soBaiBao, int soNgayCong, float bacLuong) : base(hoTen, namSinh, bangCap)
        {
            this.chucVu = chucVu;
            this.soBaiBao = soBaiBao;
            this.soNgayCong = soNgayCong;
            this.bacLuong = bacLuong;
        }

        public NhaKhoaHoc() : base()
        {
            this.chucVu = "boss";
            this.soBaiBao = 10;
            this.soNgayCong = 10;
            this.bacLuong = 1000;
        }

        public void Input()
        {
            base.Input();
            Console.Write("Chuc vu: ");
            chucVu = Console.ReadLine();
            Console.Write("So ngay cong: ");
            soNgayCong = int.Parse(Console.ReadLine());
            Console.Write("So bai bao: ");
            soBaiBao = int.Parse(Console.ReadLine());
            Console.Write("Bac luong: ");
            bacLuong = float.Parse(Console.ReadLine());
        }

        public void Output()
        {
            base.Output();
            Console.Write(String.Format("{0, -20}|{1, -3}|{2, -5}|{3, -10}|{4, -10}", chucVu, soBaiBao, soNgayCong, bacLuong,tinhLuong()));
        }

        public override double tinhLuong()
        {
            return soNgayCong*bacLuong;
        }
    }
}
