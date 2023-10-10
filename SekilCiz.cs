using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    class SekilCiz : Kaydet //Şekilleri çizdirmek için kullanılacak.
    {
        static int a = 0;
        protected static Graphics graf;
        protected static Brush firca;
        private static bool kare = false, ucgen = false, altigen = false, daire = false, ciz = false;
        private static int x, y;

        public static void secilenSekliB(string belirlenenS) //Seçilen şeklin belirlenmesi.
        {

            if (belirlenenS == "kare")
            {
                kare = true;
                daire = false;
                ucgen = false;
                altigen = false;
            }
            else if (belirlenenS == "daire")
            {
                daire = true;
                kare = false;
                ucgen = false;
                altigen = false;
            }
            else if (belirlenenS == "ucgen")
            {
                ucgen = true;
                daire = false;
                kare = false;
                altigen = false;
            }
            else if (belirlenenS == "altigen")
            {
                altigen = true;
                daire = false;
                ucgen = false;
                kare = false;
            }
        }

        public static void mouse_up() // sol tuş bırakıldığında çizim durdurulacak.
        {

            ciz = false;
            a = 1;

        }

        public static void sekilCiz(MouseEventArgs basKonum) // şeklin başlangıç koordinatlarını alma.
        {
            ciz = true;
            x = basKonum.X;
            y = basKonum.Y;

        }

        public static void sekilCiz(Panel panelAd, MouseEventArgs mouse_konum, Color renk, string strrenk)
        {


            if ((ciz == true) && kare)
            {
                graf = panelAd.CreateGraphics();
                firca = new SolidBrush(renk);
                graf.Clear(Color.Gainsboro);
                kayidiCiz(panelAd);
                int y2 = mouse_konum.Y, x2 = mouse_konum.X;

                Point[] noktalarK = { new Point(x, y), new Point(x, mouse_konum.Y), new Point(mouse_konum.X, mouse_konum.Y),
                    new Point(mouse_konum.X, y) };
                graf.FillPolygon(firca, noktalarK);

            }
            else if ((ciz == true) && daire)
            {
                graf = panelAd.CreateGraphics();
                firca = new SolidBrush(renk);
                graf.Clear(Color.Gainsboro);
                kayidiCiz(panelAd);
                graf.FillEllipse(firca, 2 * x - mouse_konum.X, 2 * y - mouse_konum.Y, 2 * (mouse_konum.X - x), 2 * (mouse_konum.Y - y));
            }
            else if (ciz == true && ucgen)
            {
                graf = panelAd.CreateGraphics();
                firca = new SolidBrush(renk);
                graf.Clear(Color.Gainsboro);
                kayidiCiz(panelAd);
                Point[] ucgenN = { new Point(x, y), new Point(x - (mouse_konum.X - x), mouse_konum.Y),
                    new Point(mouse_konum.X, mouse_konum.Y) };
                graf.FillPolygon(firca, ucgenN);
            }
            else if (ciz == true && altigen)
            {
                graf = panelAd.CreateGraphics();
                firca = new SolidBrush(renk);
                graf.Clear(Color.Gainsboro);
                kayidiCiz(panelAd);
                Point[] noktalarA = { new Point((x - (mouse_konum.X - x) / 2), y - Math.Abs(mouse_konum.Y - y)),
                    new Point(2 * x - mouse_konum.X, y), new Point((x - (mouse_konum.X - x) / 2), mouse_konum.Y),
                    new Point((x + (mouse_konum.X - x) / 2), mouse_konum.Y), new Point(mouse_konum.X, y),
                    new Point((x + (mouse_konum.X - x) / 2), y - Math.Abs(mouse_konum.Y - y)) };

                graf.FillPolygon(firca, noktalarA);
            }


        }





    }
}
