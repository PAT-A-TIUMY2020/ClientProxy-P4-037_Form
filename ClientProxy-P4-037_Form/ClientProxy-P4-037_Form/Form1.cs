using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceMtk_P1_037;

namespace ClientProxy_P4_037_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.ImatematikaClient obj = new ServiceReference1.ImatematikaClient();
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            Console.WriteLine("2 / 2 = " + hasilBagi);


            ServiceReference2.Koordinat a = new ServiceReference2.Koordinat();
            ServiceReference2.Koordinat b = new ServiceReference2.Koordinat();

            a.X = 7;
            a.Y = 8;

            b.X = 5;
            b.Y = 6;

            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;

            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));
            Console.WriteLine("Hasil Koordinat " + jarak);
            Console.ReadLine();

            label1.Text = "1 + 2 = " + hasilTambah.ToString();
            label2.Text = "3 + 2 = " + hasilKurang.ToString();
            label3.Text = "2 x 2 = " + hasilKali.ToString();
            label4.Text = "2 / 2 = " + hasilBagi.ToString();
            label5.Text = jarak.ToString();

        }
    }
}