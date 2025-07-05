using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPuzzleGame : Form
    {
        int delpoz = 0;
        int vodvizenje = 0;
        List<Bitmap> orginalLista = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        

        public frmPuzzleGame()
        {
            InitializeComponent();
            orginalLista.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
            lblBrPotezi.Text += vodvizenje;
            lblVreme.Text = "00:00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Promesaj();
        }

        void Promesaj()
        {
            do
            {
                int j;
                List<int> pozicii = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    pozicii.Remove((j = pozicii[r.Next(0, pozicii.Count)]));
                    ((PictureBox)gbSlozuvalkaBox.Controls[i]).Image = orginalLista[j];
                    if (j == 9) { delpoz = i; }
                }
            } while (Pobeda());
        }

        private void btnPromesaj_Click(object sender, EventArgs e)
        {
            DialogResult YesNo = new DialogResult();
            if (lblVreme.Text != "00:00:00")
            {
                YesNo = MessageBox.Show("Дали сте сигурни дека сакате да ја промешате сложувалката?", "ФИНКИ сложувалка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesNo == DialogResult.Yes || lblVreme.Text == "00:00:00")
            {
                Promesaj();
                timer.Reset();
                lblVreme.Text = "00:00:00";
                vodvizenje = 0;
                lblBrPotezi.Text = "Број на потези : 0";
            }
        }

        private void IzlezPoraka(object sender, FormClosingEventArgs e)
        {
            DialogResult YesNo = MessageBox.Show("Дали сте сигурни дека ќе се откажете ?", "ФИНКИ сложувалка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnIzlezi && YesNo == DialogResult.No)
            {
                e.Cancel = true;
            }
            if (sender as Button == btnIzlezi && YesNo == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnIzlezi_Click(object sender, EventArgs e)
        {
            IzlezPoraka(sender, e as FormClosingEventArgs);
        }

        private void pbSmeni(object sender, EventArgs e)
        {
            if (lblVreme.Text == "00:00:00")
                timer.Start();
            int voSlika = gbSlozuvalkaBox.Controls.IndexOf(sender as Control);
            if (delpoz != voSlika)
            {
                List<int> fb = new List<int>();

                if (voSlika % 3 == 0)

                    fb.Add(-1);
                else
                    fb.Add(voSlika - 1);

                fb.Add(voSlika - 3);

                if (voSlika % 3 == 2)
                    fb.Add(-1);
                else
                    fb.Add(voSlika + 1);

                fb.Add(voSlika + 3);
                if (fb.Contains(delpoz))
                {
                    ((PictureBox)gbSlozuvalkaBox.Controls[delpoz]).Image = ((PictureBox)gbSlozuvalkaBox.Controls[voSlika]).Image;
                    ((PictureBox)gbSlozuvalkaBox.Controls[voSlika]).Image = orginalLista[9];
                    delpoz = voSlika;
                    lblBrPotezi.Text = "Број на потези : " + (++vodvizenje);
                    if (Pobeda())
                    {
                        timer.Stop();
                        (gbSlozuvalkaBox.Controls[8] as PictureBox).Image = orginalLista[8];
                        MessageBox.Show("Честитки...\nИзминато време:" + timer.Elapsed.ToString().Remove(8) + "\nВкупен број на потези : " + vodvizenje, "ФИНКИ сложувалка");
                        vodvizenje = 0;
                        lblBrPotezi.Text = "Број на потези : 0";
                        lblVreme.Text = "00:00:00";
                        timer.Reset();
                        Promesaj();
                    }
                }
            }
        }

        bool Pobeda()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbSlozuvalkaBox.Controls[i] as PictureBox).Image != orginalLista[i])
                    break;
            }
            if (i == 8) { 
                return true; }
            else { 
                return false;
            }
        }

        private void UpdateTimer(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
            {
                lblVreme.Text = timer.Elapsed.ToString().Remove(8);
            }
            if (timer.Elapsed.ToString() == "00:00:00")
            {
                btnPauza.Enabled = false;
            }
            else
            {
                btnPauza.Enabled = true;
            }
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                lblBrPotezi.Text = "Број на потези : 0";
                lblVreme.Text = "00:00:00";
                vodvizenje = 0;
                btnPauza.Enabled = false;
                MessageBox.Show("Времето истече\nОбиди се повторно", "ФИНКИ сложувалка");
                Promesaj();
            }
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string help = "ФИНКИ Сложувалка - Упатство за играње:\n\n" +
                     "1. Кликнете на копчето „Промешај“ за да ја започнете играта на ново.\n" +
                     "2. Кликнете на парчињата кои се во близина на празното место за да ги поместите.\n" +
                     "3. Целта е да ги средите сите парчиња во правилен редослед.\n" +
                     "4. Следете го времето и обидите - обидете се да ја решите сложувалката со што помалку потези и побрзо!\n" +
                     "5. Можете да користите копчето ->Пауза за да ја паузирате играта.\n" +
                     "6. За да излезете, користете го копчето ->Излези.\n\n";

            MessageBox.Show(help, "Помош", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 9; i++)
            {
                ((PictureBox)gbSlozuvalkaBox.Controls[i]).Image = orginalLista[i];
            }

           
            delpoz = 9; 

           
            vodvizenje = 0;
            lblBrPotezi.Text = "Број на потези : 0";

            timer.Stop();
            timer.Reset();
            lblVreme.Text = "00:00:00";

        
            MessageBox.Show("Сложувалката е успешно завршена!", "ФИНКИ сложувалка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nextMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
                int i = delpoz;
                int najdobar = -1;
                int mindistanca = int.MaxValue;

                List<int> sosed = new List<int>();
            if (i % 3 != 0) { sosed.Add(i - 1); }
            if (i % 3 != 2) { sosed.Add(i + 1); }
            if (i / 3 != 0) { sosed.Add(i - 3); }
            if (i / 3 != 2) { sosed.Add(i + 3); }

                foreach (int n in sosed)
                {
                PremestiP(i, n); 

                    int distanca = PresmetajMDistanca();

                    if (distanca < mindistanca)
                    {
                    mindistanca = distanca;
                    najdobar = n;
                    }

                PremestiP(i, n);
                }

               
                if (najdobar != -1)
                Premesti(najdobar);
            }
        private void PremestiP(int i, int j)
        {
            var temp = ((PictureBox)gbSlozuvalkaBox.Controls[i]).Image;
            ((PictureBox)gbSlozuvalkaBox.Controls[i]).Image = ((PictureBox)gbSlozuvalkaBox.Controls[j]).Image;
            ((PictureBox)gbSlozuvalkaBox.Controls[j]).Image = temp;
        }

        private int PresmetajMDistanca()
        {
            int zbir = 0;

            for (int i = 0; i < 9; i++)
            {
                Bitmap slika = ((PictureBox)gbSlozuvalkaBox.Controls[i]).Image as Bitmap;

                if (slika == null)
                {
                    continue;
                }

                int poz = orginalLista.IndexOf(slika);
                if (poz == -1)
                {
                    continue;
                }
                int x1 = i % 3;
                int y1 = i / 3;
                int x2 = poz % 3;
                int y2 = poz / 3;

                zbir =zbir+ Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
            }

            return zbir;
        }

        private void Premesti(int poz)
        {
            if (poz < 0 || poz >= 9)
            {
                return;
            }

            var temp = ((PictureBox)gbSlozuvalkaBox.Controls[poz]).Image;
            ((PictureBox)gbSlozuvalkaBox.Controls[poz]).Image = ((PictureBox)gbSlozuvalkaBox.Controls[delpoz]).Image;
            ((PictureBox)gbSlozuvalkaBox.Controls[delpoz]).Image = temp;

            delpoz = poz;
        }


       

        private void PausaResume(object sender, EventArgs e)
        {
            if (btnPauza.Text == "Пауза")
            {
                timer.Stop();
                gbSlozuvalkaBox.Visible = false;
                btnPauza.Text = "Продолжи";
            }
            else
            {
                timer.Start();
                gbSlozuvalkaBox.Visible = true;
                btnPauza.Text = "Пауза";
            }
        }
    }
}