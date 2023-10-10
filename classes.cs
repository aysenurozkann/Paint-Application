using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    internal class classes
    {
    }
    class MenuRenk  //Menülere tıklandığında arka plan rengini değiştirecek.
    {
        public static void renk_degis(Panel panelAd, Color renk)
        {
            panelAd.BackColor = renk;
        }

    }
    class MenuSekilCiz //Şekilleri menü üzerine çizcek.
    {
        private static Graphics grafik;  //Çizim yapılırken kullanılacaklar.
        private static Brush firca;

        public static void MenuCiz(Panel panelAd, Color fircaRenk, Point[] noktalar) // üçgen ve altıgen çizilirken kullanılacaklar.
        {
            grafik = panelAd.CreateGraphics();
            firca = new SolidBrush(fircaRenk);
            grafik.FillPolygon(firca, noktalar);
        }

        public static void MenuCiz(Panel panelAd, string belirlenenS, Color fircaRenk, int x, int y, int w, int h)//Dikdörtgen ve daire çizilirken kullanılacaklar.
        {
            grafik = panelAd.CreateGraphics();
            firca = new SolidBrush(fircaRenk);
            if (belirlenenS == "kare")
            {
                grafik.FillRectangle(firca, x, y, w, h);
            }
            else
            {
                grafik.FillEllipse(firca, x, y, w, h);
            }
        }


    }

    class KaydiAc : Kaydet  // kaydedilen dosyası açma.
    {

        public static void oku(Panel panel2, OpenFileDialog ofd)
        {
            dosyaTemizle();
            Graphics grafik = panel2.CreateGraphics();
            Brush firca;
            grafik.Clear(Color.Gainsboro);


            try
            {


                Color renk = Color.Black;
                string[] okunan;
                okunan = File.ReadAllLines(ofd.FileName);
                string[] dosyayi_ac = new string[30];
                string xokunan;
                xokunan = File.ReadAllText(ofd.FileName);
                File.WriteAllText(Application.StartupPath.ToString() + "\\temporary.tmp", xokunan);

                for (int j = 0; j < okunan.Length; j++)
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

                    if ((okunan[j].Split(','))[0] == "daire1")
                    {
                        for (int i = 0; i < 6; i++)
                        {

                            dosyayi_ac[i] = Convert.ToString((okunan[j].Split(','))[i]);

                        }
                        firca = new SolidBrush(renk);
                        grafik.FillEllipse(firca, Convert.ToInt16(dosyayi_ac[2]), Convert.ToInt16(dosyayi_ac[3]), 
                            Convert.ToInt16(dosyayi_ac[4]), Convert.ToInt16(dosyayi_ac[5]));
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

            catch (Exception)
            {

                throw;
            }
        }
    }
    class SecilenSekil
    {
        private static string secilenSek = null;
        public static void isretle(MouseEventArgs e, Panel panel2)  //Şekil seçme metodu.
        {
            int degerX = e.X, degerY = e.Y;
            bool sekil_var = false;


            string[] oku = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
            for (int i = 0; i < oku.Length; i++)  // Mouse bir şeklin üzerinde mi
            {

                if ((oku[i].Split(','))[0] == "daire1")
                {
                    if (degerX > Convert.ToInt16((oku[i].Split(','))[2]) && degerY > Convert.ToInt16((oku[i].Split(','))[3]) && degerX < (Convert.ToInt16((oku[i].Split(','))[4]) + Convert.ToInt16((oku[i].Split(','))[2])) && degerY < ((Convert.ToInt16((oku[i].Split(','))[5]) + Convert.ToInt16((oku[i].Split(','))[3]))))
                    {
                        secilenSek = oku[i];
                        sekil_var = true;
                        Graphics grafik = panel2.CreateGraphics();
                        Pen kalem = new Pen(Color.HotPink, 3);
                        grafik.Clear(Color.Gainsboro);
                        Kaydet.kayidiCiz(panel2);
                        grafik.DrawRectangle(kalem, Convert.ToInt16((oku[i].Split(','))[2]) - 16, Convert.ToInt16((oku[i].Split(','))[3]) - 16, Convert.ToInt16((oku[i].Split(','))[4]) + 32, Convert.ToInt16((oku[i].Split(','))[5]) + 32);
                    }


                }
                else if ((oku[i].Split(','))[0] == "kare1")
                {
                    if (degerX > Convert.ToInt16((oku[i].Split(','))[2]) && degerY > Convert.ToInt16((oku[i].Split(','))[3]) && degerX < (Convert.ToInt16((oku[i].Split(','))[6])) && degerY < ((Convert.ToInt16((oku[i].Split(','))[5]))))
                    {
                        secilenSek = oku[i];
                        sekil_var = true;
                        Graphics grafik = panel2.CreateGraphics();
                        Pen kalem = new Pen(Color.HotPink, 3);
                        grafik.Clear(Color.Gainsboro);
                        Kaydet.kayidiCiz(panel2);
                        grafik.DrawRectangle(kalem, Convert.ToInt16((oku[i].Split(','))[2]) - 16, 
                            Convert.ToInt16((oku[i].Split(','))[3]) - 16, 
                            Convert.ToInt16((oku[i].Split(','))[8]) - Convert.ToInt16((oku[i].Split(','))[2]) + 32,
                            Convert.ToInt16((oku[i].Split(','))[5]) - Convert.ToInt16((oku[i].Split(','))[3]) + 32);
                    }


                }
                else if ((oku[i].Split(','))[0] == "altigen1")
                {
                    if (degerX > Convert.ToInt16((oku[i].Split(','))[4]) && degerY > Convert.ToInt16((oku[i].Split(','))[3]) && degerX < (Convert.ToInt16((oku[i].Split(','))[10])) && degerY < ((Convert.ToInt16((oku[i].Split(','))[6]))))
                    {
                        secilenSek = oku[i];
                        sekil_var = true;
                        Graphics grafik = panel2.CreateGraphics();
                        Pen kalem = new Pen(Color.HotPink, 3);
                        grafik.Clear(Color.Gainsboro);
                        Kaydet.kayidiCiz(panel2);
                        grafik.DrawRectangle(kalem, Convert.ToInt16((oku[i].Split(','))[4]) - 16, 
                            Convert.ToInt16((oku[i].Split(','))[3]) - 16, Convert.ToInt16((oku[i].Split(','))[10]) - Convert.ToInt16((oku[i].Split(','))[4]) + 32, 
                            Convert.ToInt16((oku[i].Split(','))[7]) - Convert.ToInt16((oku[i].Split(','))[13]) + 32);
                    }


                }
                else if ((oku[i].Split(','))[0] == "ucgen1")
                {
                    if (degerX > Convert.ToInt16((oku[i].Split(','))[4]) && degerY > Convert.ToInt16((oku[i].Split(','))[3]) && degerX < (Convert.ToInt16((oku[i].Split(','))[6])) && degerY < ((Convert.ToInt16((oku[i].Split(','))[7]))))
                    {
                        secilenSek = oku[i];
                        sekil_var = true;
                        Graphics grafik = panel2.CreateGraphics();
                        Pen kalem = new Pen(Color.HotPink, 3);
                        grafik.Clear(Color.Gainsboro);
                        Kaydet.kayidiCiz(panel2);
                        grafik.DrawRectangle(kalem, Convert.ToInt16((oku[i].Split(','))[4]) - 16, Convert.ToInt16((oku[i].Split(','))[3]) - 16, 
                            Convert.ToInt16((oku[i].Split(','))[6]) - Convert.ToInt16((oku[i].Split(','))[4]) + 32,
                            Convert.ToInt16((oku[i].Split(','))[5]) - Convert.ToInt16((oku[i].Split(','))[3]) + 32);
                    }


                }
            }
        }

        public static void sil(Panel panels) //Seçilen şekli silmek.
        {


            if (secilenSek != null)
            {
                try
                {

                    FileStream dosyaYaz;
                    StreamWriter yaz;
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporaryDel.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    string[] gosterS = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
                    for (int i = 0; i < gosterS.Length; i++)
                    {
                        if (gosterS[i] != secilenSek)
                        {
                            yaz.WriteLine(gosterS[i]);
                        }

                    }
                    yaz.Close();
                    dosyaYaz.Close();
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    yaz.Write(File.ReadAllText(Application.StartupPath.ToString() + "\\temporaryDel.tmp"));

                    yaz.Close();
                    dosyaYaz.Close();
                    Graphics graf = panels.CreateGraphics();
                    graf.Clear(Color.Gainsboro);
                    Kaydet.kayidiCiz(panels);

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public static void renkDegis(string renk, Panel panels) //Seçilen şeklin rengini değiştirme
        {
            if (secilenSek != null)
            {
                try
                {

                    FileStream dosyaYaz;
                    StreamWriter yaz;
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporaryDel.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    string[] gosterS = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
                    string[] uzunlukS = new string[gosterS.Length];
                    for (int i = 0; i < gosterS.Length; i++)
                    {
                        if (gosterS[i] != secilenSek)
                        {
                            yaz.WriteLine(gosterS[i]);
                        }
                        else
                        {
                            yaz.WriteLine(gosterS[i].Replace(gosterS[i].Split(',')[1], renk));
                        }

                    }
                    yaz.Close();
                    dosyaYaz.Close();
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    yaz.Write(File.ReadAllText(Application.StartupPath.ToString() + "\\temporaryDel.tmp"));

                    yaz.Close();
                    dosyaYaz.Close();
                    Graphics graf = panels.CreateGraphics();
                    graf.Clear(Color.Gainsboro);
                    Kaydet.kayidiCiz(panels);

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

    }
}
