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
        public Form1()
        {
            InitializeComponent();
        }
        public cond C1;
        public cf cf1;

        private void button1_Click(object sender, EventArgs e)
        {
            C1 = new cond("C1", 2, 0, 50.2f, 1.3f, true);    //cond (string n, int o, int e,double cmoy,double IT, bool vu) 
            cf1 = new cf("cf1",5,4,20.1f,0.56f,0.2f,0.3f,false);
            // cf (string nom, int cfO, int cfE, float cmoy, float IT, float DlO, float DlE, bool vu) // constructeur Cf
            infoCond(C1);
            iniTab();
 
        }
        public void infoCond(cond C)
        {
            MessageBox.Show("nom condition = " + C1.condName + "\n" + "origine  " + C1.condOrigine.ToString() + " \nExtrémité  " + C1.conditionExtremite.ToString() + "\nCote moyenne = " + C1.conditionCmoy.ToString() + "\n IT = " + C1.conditionIT.ToString() + "\n traite =" + C1.conditionTraitee.ToString());
            MessageBox.Show("nom condition = " + cf1.cfname + "\n" + "origine  " + cf1.cfOrigine + " \nExtrémité  " + cf1.cfExtremite + " \ncote moyenne   " +cf1.cfCmoy + " \nIT   " + cf1.cfIT + " \nDl origine  " +cf1.cfDlOrigine + " \n Dl Extrémité  " +cf1.cfExtremite+ "\n traite = " +cf1.cfTraite );
            //int a = -999;   // pour mise au point message d'erreur
            // testInt("-12.", a);
        }
        public void testInt(string s, int i)
        {
            bool result = int.TryParse(s, out i);
            if (result) { result = true; } else { MessageBox.Show(s + " n'est pas un entier"); }

        }
      
        public cf[] tabcf = new cf[10];
        public void iniTab()
        {
            MessageBox.Show(tabcf.Count().ToString());
            for (int i = 0; i <= tabcf.Count()-1; i++)
            {
                tabcf[i] = null;
            }
        }
    }
}


