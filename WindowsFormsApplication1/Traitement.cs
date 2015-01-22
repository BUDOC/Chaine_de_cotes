using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class Traitement
    {
        int[,] Tabt = new int[10, 10];
        int[,] TabDesNiveaux = new int[50, 100];
        Tablos tabTT = new Tablos();
        public Traitement() //constructeur vide
        {
        }
        public void iniTabT() //Tableau TABT vide
        {
           // Tabt[1, 1] = 2;
            int k = 0;
            this.Tabt = null;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Tabt[i, j] = -1; // c'est la que mon tablleau est nul
                }
            }
            while (this.tabTT.TabCf[k] != null)
            {                
                this.Tabt[this.tabTT.TabCf[k].Origine, this.tabTT.TabCf[k].Extremite] = k;
                this.Tabt[this.tabTT.TabCf[k].Extremite, this.tabTT.TabCf[k].Origine] = k;
                k = k + 1;
            }

        }
        public void SetValeurTabT(Tablos TT) // recupere valeur des conditions et cf
        {
            this.tabTT = TT;
            this.iniTabT();
        }
    }

}
