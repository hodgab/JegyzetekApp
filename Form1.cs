using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JegyzetekApp
{
    public partial class form_foablak : Form
    {
        public form_foablak()
        {
            InitializeComponent();
        }

        private int jegy_szam = 0;

        private void hozzaad(String jegyzet)
        {
            
            
            Panel panel = new Panel();
            panel.Name = "pnl_" + jegy_szam;
            panel.Dock= DockStyle.Top; 
            panel.Height = 60;
            panel.Location = new Point(0, jegy_szam * 60);

            FontFamily family = new FontFamily("Century Gothic");
            Label lbl_jegyzet = new Label();
            lbl_jegyzet.Text = jegyzet;
            lbl_jegyzet.Location = new Point(25, 19);
            Font font = new Font(family, 15, FontStyle.Bold);
            lbl_jegyzet.Font = font;
            lbl_jegyzet.AutoSize = true;
            lbl_jegyzet.ForeColor = System.Drawing.Color.FromArgb(235, 156, 92);

            Button btn_torles = new Button();
            btn_torles.Name = "btn_torles_" + jegy_szam;
            btn_torles.Size = new Size(25, 25);
            btn_torles.FlatStyle = FlatStyle.Flat;
            Bitmap bitmap = new Bitmap("C:\\Users\\hp\\Desktop\\csharp\\JegyzetekApp\\JegyzetekApp\\ikonok\\kuka_ikon.png");
            btn_torles.Image = bitmap;
            btn_torles.Text = "";
            btn_torles.Location = new Point(382, 19);
            btn_torles.FlatAppearance.BorderSize = 0;
            btn_torles.ImageAlign = ContentAlignment.MiddleCenter;
            btn_torles.Click += new EventHandler(btn_torles_Click);
            

            Button btn_pipa = new Button();
            btn_pipa.Name = "btn_pipa_" + jegy_szam;
            btn_pipa.Size = new Size(25, 25);
            btn_pipa.FlatStyle = FlatStyle.Flat;
            Bitmap b = new Bitmap("C:\\Users\\hp\\Desktop\\csharp\\JegyzetekApp\\JegyzetekApp\\ikonok\\pipa_ikon.png");
            btn_pipa.Image = b;
            btn_pipa.Text = "";
            btn_pipa.Location = new Point(425, 21);
            btn_pipa.FlatAppearance.BorderSize = 0;
            btn_pipa.ImageAlign = ContentAlignment.MiddleCenter;
            btn_pipa.Click += new EventHandler(btn_pipa_Click);



            panel.Controls.Add(lbl_jegyzet);
            panel.Controls.Add(btn_torles);
            panel.Controls.Add(btn_pipa);
            panel.Show();
            pnl_fo.Controls.Add(panel);
            jegy_szam+= 1;
        }

        private void pnl_fejlec_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {
            if(jegy_szam<=5)
            {
                String jegyzet = txt_uj_jegyzet.Text;
                hozzaad(jegyzet);
            }
            else
            {
                MessageBox.Show("Először csináld meg a meglévőket");
            }

            txt_uj_jegyzet.Clear();
            txt_uj_jegyzet.Focus();

        }

        private void btn_torles_Click(object sender, EventArgs e)
        {
            
            Button kattint = (Button)sender;
            String keresendo = kattint.Name;
 
            string nev = "pnl_"+ Convert.ToString(keresendo[keresendo.Length - 1]);
            foreach(Control c in pnl_fo.Controls)
            {
                if(c.Name == nev)
                {
                    pnl_fo.Controls.Remove(c);
                    jegy_szam-= 1;
                }
            }

        }

        private void btn_pipa_Click(object sender, EventArgs e)
        {
            Button kattint = (Button)sender;
            String keresendo = kattint.Name;

            String nev = "pnl_" + Convert.ToString(keresendo[keresendo.Length - 1]);
            
            foreach (Control c in pnl_fo.Controls)
            {
                if (c.Name == nev)
                {
                    c.BackColor = Color.Green;
                    c.Controls.Clear();
                    
                    Thread.Sleep(500);
                    pnl_fo.Controls.Remove(c);
                    jegy_szam -= 1;
                       

                }
            }

            if(pnl_fo.Controls.Count == 0)
            {
                MessageBox.Show("Gratulálok, megoldottál mindent!");
            }
            
            


        }

        private void btn_bezaras_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
