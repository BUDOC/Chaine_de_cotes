using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Cond C1;
        public Cf cf1;
        Tablos tablo = new Tablos();
        Traitement Traite = new Traitement();
        int t = 9; // taille caractere du richedit
        int lgc = 4; // longueur des cote dans le richedit

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C1 = new Cond("C1", 2, 0, 50.2f, 1.3f);
            cf1 = new Cf("cf1", 5, 4, 20.1f, 0.2f, 0.3f);

            tablo.iniTabcf();
            tablo.iniTabCond();
            tablo.chargePourTest();

            afficheToutCf(3);
            Traite.SetValeurTabT(tablo);
            debug();
        }

        public void afficheToutCf(int L)
        {
            int nbc = L;
            AffHautPage(nbc);
            tablo.iniTabCond();
            tablo.iniTabcf();
            tablo.chargePourTest();
            AfficheConditions(nbc);
            afficheLesCf(nbc);
        }

        public void debug()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    sb.Append(Traite.Tabt[i, k].ToString()).Append("  ");
                }
                sb.AppendLine();
            }
            richTextBox1.Text = sb.ToString();
        }

        private string AffHautPage(int nbc)
        {
            richTextBox1.Clear();
            var sb = new StringBuilder();
            for (int i = 0; i <= 10; i++)
            {
                sb.Append(i.ToString());
                for (int k = 0; k <= nbc; k++)
                {
                    sb.Append(' ');
                }
                if (i < 10) sb.Append(' ');
            }
            sb.AppendLine();
            richTextBox1.Text = sb.ToString();
            return sb.ToString();
        }

        private void afficheLesCf(int nbc)
        {
            int j = 0;
            while (tablo.TabCf[j] != null)
            {
                var sb = new StringBuilder();
                sb.Append('|');
                for (int i = 0; i <= 10; i++)
                {
                    var cf = tablo.TabCf[j];
                    if (i < cf.Origine)
                    {
                        for (int k = 0; k <= nbc + 1; k++) sb.Append(' ');
                        sb.Append('|');
                        continue;
                    }
                    if ((i == cf.Origine) && ((i + 1) == cf.Extremite))
                    {
                        sb.Append('<');
                        for (int k = 0; k <= nbc - 1; k++) sb.Append('-');
                        sb.Append(">");
                        sb.Append('|');
                        continue;
                    }
                    if ((i == cf.Origine) && ((i + 1) != cf.Extremite))
                    {
                        sb.Append('<');
                        for (int k = 0; k <= nbc; k++) sb.Append('-');
                        sb.Append('|');
                        continue;
                    }
                    if ((i > cf.Origine) && (i + 1 < cf.Extremite))
                    {
                        for (int k = 0; k <= nbc + 1; k++) sb.Append('-');
                        sb.Append('|');
                        continue;
                    }
                    if ((i == cf.Extremite) && (i - 1 != cf.Origine))
                    {
                        for (int k = 0; k <= nbc; k++) sb.Append('-');
                        sb.Append(">");
                        sb.Append('|');
                        continue;
                    }
                    if (i > cf.Extremite)
                    {
                        for (int k = 0; k <= nbc + 1; k++) sb.Append(' ');
                        sb.Append('|');
                        continue;
                    }
                }
                sb.Append("   ").Append(tablo.TabCf[j].Name).Append("  (").Append(tablo.TabCf[j].Origine).Append(",").Append(tablo.TabCf[j].Extremite).Append(")\n");
                j++;
                richTextBox1.AppendText(sb.ToString());
            }
        }

        private void AfficheConditions(int nbc)
        {
            int j = 0;
            while (tablo.TabCond[j] != null)
            {
                var sb = new StringBuilder();
                sb.Append('|');
                for (int i = 0; i <= 11; i++)
                {
                    var cond = tablo.TabCond[j];
                    if (i < cond.Origine)
                    {
                        for (int k = 0; k <= nbc + 1; k++) sb.Append(' ');
                        sb.Append('|');
                        continue;
                    }
                    if ((i == cond.Origine) && ((i + 1) == cond.Extremite))
                    {
                        sb.Append('O');
                        for (int k = 0; k <= nbc - 1; k++) sb.Append('=');
                        sb.Append(">");
                        sb.Append('|');
                        continue;
                    }
                    if ((i == cond.Origine) && ((i + 1) != cond.Extremite))
                    {
                        sb.Append('<');
                        for (int k = 0; k <= nbc; k++) sb.Append('=');
                        sb.Append('|');
                        continue;
                    }
                    if ((i > cond.Origine) && (i + 1 < cond.Extremite))
                    {
                        for (int k = 0; k <= nbc + 1; k++) sb.Append('=');
                        sb.Append('|');
                        continue;
                    }
                    if ((i == cond.Extremite) && (i - 1 != cond.Origine))
                    {
                        for (int k = 0; k <= nbc + 1; k++) sb.Append('=');
                        sb.Append('|');
                        continue;
                    }
                    if (i > cond.Extremite)
                    {
                        for (int k = 0; k <= nbc + 1; k++) sb.Append(' ');
                        sb.Append('|');
                        continue;
                    }
                }
                richTextBox1.AppendText(sb.ToString());
                richTextBox1.AppendText("    " + tablo.TabCond[j].Name + "  (" + tablo.TabCond[j].Origine + "," + tablo.TabCond[j].Extremite + ")\n");
                j++;
            }
            richTextBox1.AppendText("\n");
        }

        public void infoCond(Cond C)
        {
            if (C == null) return;
            MessageBox.Show("nom condition = " + C.Name + "\n" + "origine  " + C.Origine + " \nExtrémité  " + C.Extremite + "\nCote moyenne = " + C.Cmoy + " \nIT = " + C.IT);
        }

        public void testInt(string s, int i)
        {
            if (!int.TryParse(s, out i))
            {
                MessageBox.Show(s + " n'est pas un entier");
            }
        }

        private void numericUpDownFont_ValueChanged(object sender, EventArgs e)
        {
            t = Convert.ToInt32(this.numericUpDownFont.Value);
            this.richTextBox1.Font = new Font("Courier New", t, FontStyle.Regular);
            afficheToutCf(lgc);
        }

        private void numericUpDownCote_ValueChanged(object sender, EventArgs e)
        {
            lgc = Convert.ToInt32(this.numericUpDownCote.Value);
            afficheToutCf(lgc);
        }
    }
}
