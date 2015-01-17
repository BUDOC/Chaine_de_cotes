using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public cond C1;
        public cf cf1;
        Tablos tablo = new Tablos();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C1 = new cond("C1", 2, 0, 50.2f, 1.3f);    //cond (string n, int o, int e,double cmoy,double IT, bool vu) 
            cf1 = new cf("cf1", 5, 4, 20.1f, 0.2f, 0.3f);
            // cf (string nom, int cfO, int cfE, float cmoy, float IT, float DlO, float DlE, bool vu) // constructeur Cf
            //  infoCond(C1);
            tablo.iniTabcf();
            tablo.iniTabCond();
            tablo.chargePourTest();
            affiche();
         
        }
       

        public void affiche() //Tableau des cf vide
        {
            string S = "";
            this.richTextBox1.Clear();
            this.richTextBox1.Font = new Font("Courier New", 8, FontStyle.Regular);

            for (int i = 0; i <= 10; i++)  //n identification des surfaces en haut du richtextbox
            {
                S = S + i.ToString() + "      ";
                if (i < 10) { S = S + " "; }
            }
            S = S +"\n";
        
            this.richTextBox1.Text = richTextBox1.Text + S;
           
         
            this.richTextBox1.Clear();
            this.richTextBox1.Text = richTextBox1.Text + S;
     
            tablo.iniTabCond();
            tablo.iniTabcf();
            tablo.chargePourTest();
            int j = 0;           //****************  AFFICHAGE DES conditions
            while (tablo.TabCond[j] != null)
            {
                S = "|";
                for (int i = 0; i <= 11; i++)
                {
                    if (i < tablo.TabCond[j].conditionOrigine) // inférieur à origine
                    {
                        S = S + "       |";
                    }
                    if ((i == tablo.TabCond[j].conditionOrigine) && ((i + 1) == tablo.TabCond[j].conditionExtremite)) //  cond deux surfaces consécutives
                    {
                        S = S + "O=====>|";
                    }
                    if ((i == tablo.TabCond[j].conditionOrigine) && ((i + 1) != tablo.TabCond[j].conditionExtremite))    // debut de cond
                    {
                        S = S + "<=======";
                    }
                    if ((i > tablo.TabCond[j].conditionOrigine) && (i + 1 < tablo.TabCond[j].conditionExtremite)) // en court de cond
                    {
                        S = S + "========";
                    }
                    if ((i == tablo.TabCond[j].conditionExtremite) && (i - 1 != tablo.TabCond[j].conditionOrigine))// fin de cf
                    {
                        S = S + "======>|";
                    }
                    if (i > tablo.TabCf[j].Extremite) // supérieur a extrémité
                    {
                        S = S + "       |";
                    }
                    //  if (i < 9) { S = S + " "; }
                }

               
                this.richTextBox1.Text = richTextBox1.Text + S+"    "+ tablo.TabCond[j].condName+ "  (" + tablo.TabCond[j].conditionOrigine + "," + tablo.TabCond[j].conditionExtremite+ ")\n";
             
                 j = j + 1;
            }
            //=============
            this.richTextBox1.Text = richTextBox1.Text + "\n";
      
             j = 0;           //****************  AFFICHAGE DES CF
            while (tablo.TabCf[j] != null)
            {                               
                 S = "|";
                for (int i = 0; i <= 10; i++)
                {
                    if (i < tablo.TabCf[j].Origine) // inférieur à origine
                    {
                    S = S + "       |";
                    }
                    if ((i == tablo.TabCf[j].Origine)  && ( (i+1)== tablo.TabCf[j].Extremite)) //  cf deux surfaces consécutives
                    {
                        S = S + "<----->|";
                    }
                    if ((i == tablo.TabCf[j].Origine)  && ( (i+1)!= tablo.TabCf[j].Extremite) )    // debut de cf
                    {
                        S = S + "<-------";
                    }
                     if ((i >tablo.TabCf[j].Origine)  && ( i+1 < tablo.TabCf[j].Extremite)) // en court de cf
                    {
                        S = S + "--------";
                    }
                     if  ((i== tablo.TabCf[j].Extremite) &&(i-1!=tablo.TabCf[j].Origine))// fin de cf
                    {
                        S = S + "------>|";
                    }
                     if (i > tablo.TabCf[j].Extremite) // supérieur a extrémité
                     {
                         S = S + "       |";
                     }
                  //  if (i < 9) { S = S + " "; }
                }               
                if (tablo.TabCf[j] != null)
                { S = S +"   " + tablo.TabCf[j].cfname +"  ("+tablo.TabCf[j].Origine+","+ tablo.TabCf[j].Extremite+")\n"; }
                else
                {
                    S = S + "\n";
                }
                j = j + 1;
                this.richTextBox1.Text = richTextBox1.Text + S;
            }
        }
        public void infoCond(cond C)
        {
            MessageBox.Show("nom condition = " + C1.condName + "\n" + "origine  " + C1.condOrigine.ToString() + " \nExtrémité  " + C1.conditionExtremite.ToString() + "\nCote moyenne = " + C1.conditionCmoy.ToString() + "\n IT = " + C1.conditionIT.ToString());
            MessageBox.Show("nom condition = " + cf1.cfname + "\n" + "origine  " + cf1.cfOrigine + " \nExtrémité  " + cf1.cfExtremite + " \ncote moyenne   " + cf1.cfCmoy + " \nDl origine  " + cf1.cfDlOrigine + " \n Dl Extrémité  " + cf1.cfExtremite);
            //int a = -999;   // pour mise au point message d'erreur
            // testInt("-12.", a);            
        }
        public void testInt(string s, int i)
        {
            bool result = int.TryParse(s, out i);
            if (result) { result = true; } else { MessageBox.Show(s + " n'est pas un entier"); }
        }

    }
}


