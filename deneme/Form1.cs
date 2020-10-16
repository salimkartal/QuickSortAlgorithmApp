using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tiklanma_sayisi = 0;
        //zaman karmaşıklığı için
        double timecmp,n;
        
        private void button1_Click(object sender, EventArgs e)
        {

            int[] eldendizi = new int[5];
            int sayi = Convert.ToInt32(textBox1.Text);
            eldendizi[0] = sayi;
            int sayi1 = Convert.ToInt32(textBox2.Text);
            eldendizi[1] = sayi1;
            int sayi2 = Convert.ToInt32(textBox3.Text);
            eldendizi[2] = sayi2;
            int sayi3 = Convert.ToInt32(textBox4.Text);
            eldendizi[3] = sayi3;
            int sayi4 = Convert.ToInt32(textBox5.Text);
            eldendizi[4] = sayi4;

            tiklanma_sayisi++;

            Quick_Sort(eldendizi, 0, 5);
            SIRALAMA.Items.Clear();
            for (int i = 0; i < eldendizi.Length-4; i++)
            {
                if (tiklanma_sayisi == 1)
                {
                    SIRALAMA.Items.Add(eldendizi[i]);
                    label1.Text = (textBox4.Text + " pivot secildi");
                    button1.Text = "2.ADIM";
                    
                }

            }
            for (int i = 0; i < eldendizi.Length - 3; i++)
            {
                if (tiklanma_sayisi == 2)
                {
                    SIRALAMA.Items.Add(eldendizi[i]);
                    label1.Text = "Sayilar sag ve sol alt gruba ayrıldı";
                    button1.Text = "3.ADIM";
                }

            }
            for (int i = 0; i < eldendizi.Length - 2; i++)
            {
                if (tiklanma_sayisi == 3)
                {
                    SIRALAMA.Items.Add(eldendizi[i]);
                    label1.Text = "Sayilar kendi içlerinde karsilastirildi \nve sıralama devam ediyor";
                    button1.Text = "4.ADIM";
                }

            }
            for (int i = 0; i < eldendizi.Length - 1; i++)
            {
                if (tiklanma_sayisi == 4)
                {
                    SIRALAMA.Items.Add(eldendizi[i]);
                    label1.Text = "Parçala ve fethet yöntemi ile her alt gruptada \npivot seciliyor ta ki sıralamayı elde edene kadar";
                    button1.Text = "5.ADIM";
                }

            }
            for (int i = 0; i < eldendizi.Length; i++)
            {
                if (tiklanma_sayisi == 5)
                {
                    SIRALAMA.Items.Add(eldendizi[i]);
                    timecmp=Math.Pow(n,2)+n+12;
                    button1.Text = "BİTTİ";
                    label1.Text = "Time Complexity: n^2 + 3n +12 \nBig O Notasyonu: nlogn";
                }
            }

            


            textBox4.BackColor = Color.Yellow;
            
          
        }

       static int[] Quick_Sort(int[] dizi, int sol, int sag)
        {
            int p = dizi[sag - 1], i = sol, j = sag - 2, temp = 0;
          
            if (sag - sol > 2)
            {
                while (i < j)
                {

                    while (dizi[i] < p) { i++; }

                    while (j > 0 && dizi[j] > p) { j--; }

                    if (i < j)
                    {
                        temp = dizi[i];
                        dizi[i++] = dizi[j];
                        dizi[j--] = temp;
                    }
                }
            }
            //Pivot elemanı karşılaştır ve yer değiştir
            if (p < dizi[i])
            {
                temp = dizi[i];
                dizi[i] = dizi[sag - 1];
                dizi[sag - 1] = temp;
            }

            //Solda eleman varsa
            if (i - sol > 1)
                dizi = Quick_Sort(dizi, sol, i);

            //Sağda eleman varsa
            if (sag - (i + 1) > 1)
                dizi = Quick_Sort(dizi, i + 1, sag);

            return dizi;
        }
    }
}
