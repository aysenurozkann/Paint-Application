using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    class Kaydet //Kaydetme ve ve yeniden çizme işlemlerini yapacak.
    {


        private static FileStream dosyaYaz;
        private static StreamWriter yaz;
        protected static string dosyaYolu;
        public static void dosyaTemizle()
        {
            dosyaYolu = Application.StartupPath.ToString() + "\\temporary.tmp";
            dosyaYaz = new FileStream(dosyaYolu, FileMode.Truncate);
            yaz = new StreamWriter(dosyaYaz);

            yaz.Write("");
            yaz.Flush();
            yaz.Close();
            dosyaYaz.Close();
        }


        public static void kayidiCiz(Panel panel2) //Kaydedilen dosyadaki şekillerin çizdirilmesi.
        {
            Graphics grafik = panel2.CreateGraphics();
            Brush firca;



            Color renk = Color.Black;
            string[] okunan;
            okunan = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
            string[] dosyayi_ac = new string[30];




            for (int j = 0; j < okunan.Length; j++)   //okunan şeklin renginin belirlenmesi.
            {

                if ((okunan[j].Split(','))[1] == "kirmizi")
                {
                    renk = Color.Red;
                }
                else if ((okunan[j].Split(','))[1] == "kahve")
                {
                    renk = Color.Brown;
                }
                else if ((okunan[j].Split(','))[1] == "mavi")
                {
                    renk = Color.Blue;
                }
                else if ((okunan[j].Split(','))[1] == "yesil")
                {
                    renk = Color.Green;
                }
                else if ((okunan[j].Split(','))[1] == "sari")
                {
                    renk = Color.Yellow;
                }
                else if ((okunan[j].Split(','))[1] == "turuncu")
                {
                    renk = Color.Orange;
                }
                else if ((okunan[j].Split(','))[1] == "mor")
                {
                    renk = Color.Purple;
                }
                else if ((okunan[j].Split(','))[1] == "siyah")
                {
                    renk = Color.Black;
                }
                else if ((okunan[j].Split(','))[1] == "beyaz")
                {
                    renk = Color.White;
                }

                if ((okunan[j].Split(','))[0] == "daire1") //Okunan verideki şeklin türünü belirleme.
                {
                    for (int i = 0; i < 6; i++)
                    {

                        dosyayi_ac[i] = Convert.ToString((okunan[j].Split(','))[i]); //Şeklin koordinatlarını kaydetme.

                    }
                    firca = new SolidBrush(renk);
                    grafik.FillEllipse(firca, Convert.ToInt16(dosyayi_ac[2]), Convert.ToInt16(dosyayi_ac[3]),
                        Convert.ToInt16(dosyayi_ac[4]), Convert.ToInt16(dosyayi_ac[5]));   //Okunulan veriye göre şekli ekrana çizme.
                }
                else if ((okunan[j].Split(','))[0] == "ucgen1")
                {
                    for (int i = 0; i < 8; i++)
                    {

                        dosyayi_ac[i] = Convert.ToString((okunan[j].Split(','))[i]);

                    }

                    Point[] noktalar = { new Point(Convert.ToInt16(dosyayi_ac[2]), Convert.ToInt16(dosyayi_ac[3])),
                        new Point(Convert.ToInt16(dosyayi_ac[4]), Convert.ToInt16(dosyayi_ac[5])),
                        new Point(Convert.ToInt16(dosyayi_ac[6]), Convert.ToInt16(dosyayi_ac[7])) };
                    firca = new SolidBrush(renk);
                    grafik.FillPolygon(firca, noktalar);

                }
                else if ((okunan[j].Split(','))[0] == "altigen1")
                {
                    for (int i = 0; i < 14; i++)
                    {

                        dosyayi_ac[i] = Convert.ToString((okunan[j].Split(','))[i]);

                    }
                    Point[] noktalar = { new Point(Convert.ToInt16(dosyayi_ac[2]), Convert.ToInt16(dosyayi_ac[3])),
                        new Point(Convert.ToInt16(dosyayi_ac[4]), Convert.ToInt16(dosyayi_ac[5])),
                        new Point(Convert.ToInt16(dosyayi_ac[6]), Convert.ToInt16(dosyayi_ac[7])),
                        new Point(Convert.ToInt16(dosyayi_ac[8]), Convert.ToInt16(dosyayi_ac[9])),
                        new Point(Convert.ToInt16(dosyayi_ac[10]), Convert.ToInt16(dosyayi_ac[11])),
                        new Point(Convert.ToInt16(dosyayi_ac[12]), Convert.ToInt16(dosyayi_ac[13])) };
                    firca = new SolidBrush(renk);
                    grafik.FillPolygon(firca, noktalar);
                }
                else if ((okunan[j].Split(','))[0] == "kare1")
                {
                    for (int i = 0; i < 10; i++)
                    {

                        dosyayi_ac[i] = Convert.ToString((okunan[j].Split(','))[i]);

                    }

                    Point[] noktalar = { new Point(Convert.ToInt16(dosyayi_ac[2]), Convert.ToInt16(dosyayi_ac[3])),
                        new Point(Convert.ToInt16(dosyayi_ac[4]), Convert.ToInt16(dosyayi_ac[5])),
                        new Point(Convert.ToInt16(dosyayi_ac[6]), Convert.ToInt16(dosyayi_ac[7])),
                        new Point(Convert.ToInt16(dosyayi_ac[8]), Convert.ToInt16(dosyayi_ac[9])) };
                    firca = new SolidBrush(renk);
                    grafik.FillPolygon(firca, noktalar);

                }


            }



        }

        public static void daire(string renk, int n1, int n2, int n3, int n4)  //Daire şeklini kaydetme.
        {
            dosyaYolu = Application.StartupPath.ToString() + "\\temporary.tmp";
            dosyaYaz = new FileStream(dosyaYolu, FileMode.Append);
            yaz = new StreamWriter(dosyaYaz);
            string noktad1, noktad2, noktad3, noktad4;

            noktad1 = Convert.ToString(n1);
            noktad2 = Convert.ToString(n2);
            noktad3 = Convert.ToString(n3);
            noktad4 = Convert.ToString(n4);

            yaz.WriteLine("daire1," + renk + "," + noktad1 + "," + noktad2 + "," + noktad3 + "," + noktad4);
            yaz.Close();
            dosyaYaz.Close();
        }



        public static void cokgen(string renk, Point[] noktalar)  //Kare,üçgen ve altıgen şekillerini kaydedecek.
        {
            dosyaYolu = Application.StartupPath.ToString() + "\\temporary.tmp";
            dosyaYaz = new FileStream(dosyaYolu, FileMode.Append);
            yaz = new StreamWriter(dosyaYaz);
            int x = noktalar.Length;
            if (noktalar.Length == 4)
            {
                yaz.Write("kare1,");
            }
            else if (noktalar.Length == 3)
            {
                yaz.Write("ucgen1,");
            }
            else if (noktalar.Length == 6)
            {
                yaz.Write("altigen1,");
            }

            yaz.Write(renk);
            for (int i = 0; i < x; i++)
            {

                if (i == x - 1)
                {
                    yaz.WriteLine("," + noktalar[i].X + "," + noktalar[i].Y);
                }
                else
                {
                    yaz.Write("," + noktalar[i].X + "," + noktalar[i].Y);
                }


            }

            yaz.Close();
            dosyaYaz.Close();

        }

        public static void dosyayaKaydet(SaveFileDialog dia) // Dosyayı kaydetme işlemi.
        {
            StreamWriter streamw = new StreamWriter(dia.FileName);
            FileStream filestream = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Open, FileAccess.Read);
            StreamReader streamr = new StreamReader(filestream);
            string yazi = streamr.ReadLine();
            while (yazi != null)
            {

                streamw.WriteLine(yazi);
                yazi = streamr.ReadLine();
            }
            streamw.Close();
            streamr.Close();
            filestream.Close();

        }



    }
}
