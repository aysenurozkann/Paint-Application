using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        bool secim_kare = false, secim_daire = false, secim_ucgen = false, secim_altigen = false;
        Color secilen_renk = Color.Black;
        bool ciz = false, sec = false;
        string string_renk = "siyah";
        string sekil = " ";
        int x, y;
        



        private void sil_panel_MouseClick(object sender, MouseEventArgs e)
        {
            SecilenSekil.sil(panel2);
            sec = false;
            MenuRenk.renk_degis(sec_panel, Color.White);
            ciz = true;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (sec)
                SecilenSekil.isretle(e, panel2);
        }

        private void altigen_panel_MouseClick(object sender, MouseEventArgs e)
        {
            sekil = "altigen1";
            SekilCiz.secilenSekliB("altigen");
            MenuRenk.renk_degis(kare_panel, Color.PeachPuff);
            MenuRenk.renk_degis(daire_panel, Color.PeachPuff);
            MenuRenk.renk_degis(ucgen_panel, Color.PeachPuff);
            MenuRenk.renk_degis(altigen_panel, Color.LightPink);

            secim_daire = false;
            secim_kare = false;
            secim_ucgen = false;
            secim_altigen = true;
        }

        private void ucgen_panel_MouseClick(object sender, MouseEventArgs e)
        {
            sekil = "ucgen1";
            SekilCiz.secilenSekliB("ucgen");
            MenuRenk.renk_degis(kare_panel, Color.PeachPuff);
            MenuRenk.renk_degis(daire_panel, Color.PeachPuff);
            MenuRenk.renk_degis(ucgen_panel, Color.LightPink);
            MenuRenk.renk_degis(altigen_panel, Color.PeachPuff);

            secim_daire = false;
            secim_kare = false;
            secim_ucgen = true;
            secim_altigen = false;
        }

        private void daire_panel_MouseClick(object sender, MouseEventArgs e)
        {
            sekil = "daire1";
            SekilCiz.secilenSekliB("daire");
            MenuRenk.renk_degis(kare_panel, Color.PeachPuff);
            MenuRenk.renk_degis(daire_panel, Color.LightPink);
            MenuRenk.renk_degis(ucgen_panel, Color.PeachPuff);
            MenuRenk.renk_degis(altigen_panel, Color.PeachPuff);


            secim_ucgen = false;
            secim_altigen = false;
            secim_daire = true;
            secim_kare = false;
        }

        private void kare_panel_MouseClick(object sender, MouseEventArgs e)
        {
            sekil = "kare1";
            SekilCiz.secilenSekliB("kare");
            MenuRenk.renk_degis(kare_panel, Color.LightPink);
            MenuRenk.renk_degis(daire_panel, Color.PeachPuff);
            MenuRenk.renk_degis(ucgen_panel, Color.PeachPuff);
            MenuRenk.renk_degis(altigen_panel, Color.PeachPuff);

            secim_ucgen = false;
            secim_altigen = false;
            secim_daire = false;
            secim_kare = true;
        }

        private void sec_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (sec_panel.BackColor == Color.LightPink)
            {
                MenuRenk.renk_degis(sec_panel, Color.White);
            }
            else
            {
                MenuRenk.renk_degis(sec_panel, Color.LightPink);
                MenuRenk.renk_degis(sil_panel, Color.White);
                secim_ucgen = false;
                secim_altigen = false;
                secim_daire = false;
                secim_kare = false;
                MenuRenk.renk_degis(kare_panel, Color.PeachPuff);
                MenuRenk.renk_degis(ucgen_panel, Color.PeachPuff);
                MenuRenk.renk_degis(daire_panel, Color.PeachPuff);
                MenuRenk.renk_degis(altigen_panel, Color.PeachPuff);
            }

            if (sec == false)
            {
                ciz = false;
                sec = true;
            }
            else
            {
                ciz = true;
                sec = false;
            }
        }

        private void btn_beyaz_MouseClick(object sender, MouseEventArgs e)
        {
            string_renk = "beyaz";
            secilen_renk = Color.White;
            MenuRenk.renk_degis(panel_kirmizi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mavi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_yesil, Color.SkyBlue);
            MenuRenk.renk_degis(panel_turuncu, Color.SkyBlue);
            MenuRenk.renk_degis(panel_siyah, Color.SkyBlue);
            MenuRenk.renk_degis(panel_sari, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mor, Color.SkyBlue);
            MenuRenk.renk_degis(panel_kahve, Color.SkyBlue);
            MenuRenk.renk_degis(panel_beyaz, Color.LightPink);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void btn_kahve_Click(object sender, EventArgs e)
        {
            string_renk = "kahve";
            secilen_renk = Color.Brown;
            MenuRenk.renk_degis(panel_kirmizi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mavi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_yesil, Color.SkyBlue);
            MenuRenk.renk_degis(panel_turuncu, Color.SkyBlue);
            MenuRenk.renk_degis(panel_siyah, Color.SkyBlue);
            MenuRenk.renk_degis(panel_sari, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mor, Color.SkyBlue);
            MenuRenk.renk_degis(panel_kahve, Color.LightPink);
            MenuRenk.renk_degis(panel_beyaz, Color.SkyBlue);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void btn_mor_MouseClick(object sender, MouseEventArgs e)
        {
            string_renk = "mor";
            secilen_renk = Color.Purple;
            MenuRenk.renk_degis(panel_kirmizi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mavi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_yesil, Color.SkyBlue);
            MenuRenk.renk_degis(panel_turuncu, Color.SkyBlue);
            MenuRenk.renk_degis(panel_siyah, Color.SkyBlue);
            MenuRenk.renk_degis(panel_sari, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mor, Color.LightPink);
            MenuRenk.renk_degis(panel_kahve, Color.SkyBlue);
            MenuRenk.renk_degis(panel_beyaz, Color.SkyBlue);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void btn_sari_MouseClick(object sender, MouseEventArgs e)
        {
            string_renk = "sari";
            secilen_renk = Color.Yellow;
            MenuRenk.renk_degis(panel_kirmizi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mavi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_yesil, Color.SkyBlue);
            MenuRenk.renk_degis(panel_turuncu, Color.SkyBlue);
            MenuRenk.renk_degis(panel_siyah, Color.SkyBlue);
            MenuRenk.renk_degis(panel_sari, Color.LightPink);
            MenuRenk.renk_degis(panel_mor, Color.SkyBlue);
            MenuRenk.renk_degis(panel_kahve, Color.SkyBlue);
            MenuRenk.renk_degis(panel_beyaz, Color.SkyBlue);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void btn_siyah_MouseClick(object sender, MouseEventArgs e)
        {
            string_renk = "siyah";
            secilen_renk = Color.Black;
            MenuRenk.renk_degis(panel_kirmizi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mavi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_yesil, Color.SkyBlue);
            MenuRenk.renk_degis(panel_turuncu, Color.SkyBlue);
            MenuRenk.renk_degis(panel_siyah, Color.LightPink);
            MenuRenk.renk_degis(panel_sari, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mor, Color.SkyBlue);
            MenuRenk.renk_degis(panel_kahve, Color.SkyBlue);
            MenuRenk.renk_degis(panel_beyaz, Color.SkyBlue);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void btn_turuncu_MouseClick(object sender, MouseEventArgs e)
        {
            string_renk = "turuncu";
            secilen_renk = Color.Orange;
            MenuRenk.renk_degis(panel_kirmizi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mavi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_yesil, Color.SkyBlue);
            MenuRenk.renk_degis(panel_turuncu, Color.LightPink);
            MenuRenk.renk_degis(panel_siyah, Color.SkyBlue);
            MenuRenk.renk_degis(panel_sari, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mor, Color.SkyBlue);
            MenuRenk.renk_degis(panel_kahve, Color.SkyBlue);
            MenuRenk.renk_degis(panel_beyaz, Color.SkyBlue);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void btn_yesil_MouseClick(object sender, MouseEventArgs e)
        {
            string_renk = "yesil";
            secilen_renk = Color.Green;
            MenuRenk.renk_degis(panel_kirmizi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mavi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_yesil, Color.LightPink);
            MenuRenk.renk_degis(panel_turuncu, Color.SkyBlue);
            MenuRenk.renk_degis(panel_siyah, Color.SkyBlue);
            MenuRenk.renk_degis(panel_sari, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mor, Color.SkyBlue);
            MenuRenk.renk_degis(panel_kahve, Color.SkyBlue);
            MenuRenk.renk_degis(panel_beyaz, Color.SkyBlue);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void btn_mavi_MouseClick(object sender, MouseEventArgs e)
        {
            string_renk = "mavi";
            secilen_renk = Color.Blue;
            MenuRenk.renk_degis(panel_kirmizi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mavi, Color.LightPink);
            MenuRenk.renk_degis(panel_yesil, Color.SkyBlue);
            MenuRenk.renk_degis(panel_turuncu, Color.SkyBlue);
            MenuRenk.renk_degis(panel_siyah, Color.SkyBlue);
            MenuRenk.renk_degis(panel_sari, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mor, Color.SkyBlue);
            MenuRenk.renk_degis(panel_kahve, Color.SkyBlue);
            MenuRenk.renk_degis(panel_beyaz, Color.SkyBlue);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void btn_kirmizi_MouseClick(object sender, MouseEventArgs e)
        {
            string_renk = "kirmizi";
            secilen_renk = Color.Red;
            MenuRenk.renk_degis(panel_kirmizi, Color.LightPink);
            MenuRenk.renk_degis(panel_mavi, Color.SkyBlue);
            MenuRenk.renk_degis(panel_yesil, Color.SkyBlue);
            MenuRenk.renk_degis(panel_turuncu, Color.SkyBlue);
            MenuRenk.renk_degis(panel_siyah, Color.SkyBlue);
            MenuRenk.renk_degis(panel_sari, Color.SkyBlue);
            MenuRenk.renk_degis(panel_mor, Color.SkyBlue);
            MenuRenk.renk_degis(panel_kahve, Color.SkyBlue);
            MenuRenk.renk_degis(panel_beyaz, Color.SkyBlue);
            if (sec)
            {
                SecilenSekil.renkDegis(string_renk, panel2);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            SekilCiz.mouse_up();
            if (!sec)
            {
                if (secim_kare)
                {
                    Point[] noktalarK = { new Point(x, y), new Point(x, e.Y), new Point(e.X, e.Y), new Point(e.X, y) };
                    Kaydet.cokgen(string_renk, noktalarK);
                }
                else if (secim_daire)
                {
                    Kaydet.daire(string_renk, (2 * x - e.X), (2 * y - e.Y), (2 * (e.X - x)), (2 * (e.Y - y)));
                }
                else if (secim_ucgen)
                {
                    Point[] ucgenN = { new Point(x, y), new Point(Math.Abs(x - (e.X - x)), e.Y), new Point(e.X, e.Y) };
                    Kaydet.cokgen(string_renk, ucgenN);
                }

                else if (secim_altigen)
                {
                    Point[] noktalarA = { new Point(Math.Abs((x - (e.X - x) / 2)), Math.Abs(y - Math.Abs(e.Y - y))), new Point(Math.Abs(2 * x - e.X), y), new Point(Math.Abs((x - (e.X - x) / 2)), e.Y), new Point((x + (e.X - x) / 2), e.Y), new Point(e.X, y), new Point((x + (e.X - x) / 2), Math.Abs(y - Math.Abs(e.Y - y))) };
                    Kaydet.cokgen(string_renk, noktalarA);

                }
            }
            ciz = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ciz)
                SekilCiz.sekilCiz(panel2, e, secilen_renk, string_renk);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kaydet.dosyaTemizle();
        }

        private void ac_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (ac_panel.BackColor == Color.LightPink)
            {
                MenuRenk.renk_degis(ac_panel, Color.LightGreen);
            }
            else
            {
                MenuRenk.renk_degis(ac_panel, Color.LightPink);
                MenuRenk.renk_degis(kaydet_panel, Color.LightGreen);
            }
            OpenFileDialog oku = new OpenFileDialog();
            if (oku.ShowDialog() == DialogResult.OK)
            {
                KaydiAc.oku(panel1, oku);

            }
            MenuRenk.renk_degis(ac_panel, Color.LightGreen);

        }


        private void kaydet_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (kaydet_panel.BackColor == Color.LightPink)
            {
                MenuRenk.renk_degis(kaydet_panel, Color.LightGreen);
            }
            else
            {
                MenuRenk.renk_degis(kaydet_panel, Color.LightPink);
                MenuRenk.renk_degis(ac_panel, Color.LightGreen);
            }
            SaveFileDialog kayit = new SaveFileDialog();
            if (kayit.ShowDialog() == DialogResult.OK)
            {
                Kaydet.dosyayaKaydet(kayit);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ucgen_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void daire_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kare_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void altigen_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (!sec)
                ciz = true;
            if (ciz)
                SekilCiz.sekilCiz(e);
            x = e.X;
            y = e.Y;
        }












    }
}
