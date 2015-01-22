using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class Traitement
    {
        public int[,] Tabt = new int[10, 10];
        int[,] TabDesNiveaux = new int[10, 15];
        public Tablos tabTT = new Tablos();

        public Traitement() //constructeur vide
        {
        }

        public void iniTabT() //Tableau TABT vide
        {
            int nbliTabt = Tabt.GetUpperBound(0);
            int nbcoTabt = Tabt.GetUpperBound(1);
            int k = 0;
            for (int ii = 0; ii <= nbliTabt; ii++)
            {
                for (int j = 0; j <= nbcoTabt; j++)
                {
                    Tabt[ii, j] = -1;
                }
            }
            int nblTabNiv = this.TabDesNiveaux.GetUpperBound(0);
            int nbcoTabNinv = this.TabDesNiveaux.GetUpperBound(1);
            while (this.tabTT.TabCf[k] != null) // initialise le tableau en récupérant les valeurs de l'objet de type tablo passé à la classe
            {
                this.Tabt[this.tabTT.TabCf[k].Origine, this.tabTT.TabCf[k].Extremite] = k;
                this.Tabt[this.tabTT.TabCf[k].Extremite, this.tabTT.TabCf[k].Origine] = k;
                k = k + 1;
            }
            for (int i = 0; i <= nblTabNiv; i++) // initialise le tableau des niveaux
            {
                for (int j = 0; j <= nbcoTabNinv; j++)
                {
                    this.TabDesNiveaux[i, j] = -1;
                }
            }
            cherche(3, 4);
        }
        public void cherche(int o, int e)
        {
            bool ok = false;
            int nivo = 0;
            int pos = 0;
            int co = this.Tabt.GetUpperBound(1);
            int li = this.Tabt.GetUpperBound(0);
            for (int i = 0; i < co; i++) // trouve les cf qui sont en realtion avec l'origine de la condition
            {
                if (this.Tabt[o, i] != -1)
                {
                    this.TabDesNiveaux[nivo, pos] = Tabt[o, i]; // rentre les cf trouvées dans le tableau des niveau au niveau "nivo"
                    pos = pos + 1;
                    if (Tabt[o, i] == e)
                    {
                        ok = true;
                    }
                }
            }
            // efface les cf trouvées sur la ligne ainsi que leurs symétrique par rapport à la diagonale *********
            cf Cfr = new cf();
            Cfr = new cf();
            for (int i2 = 0; i2 <pos; i2++)
            {
               // retrouve la position de la cf par son origine et son extrémité              
                Cfr = this.tabTT.TabCf[this.TabDesNiveaux[nivo,i2]];
                o = Cfr.Origine;
                e = Cfr.Extremite;
                Tabt[o,e]=-1;
                Tabt[e, o] = -1;
            }
        }
        public void SetValeurTabT(Tablos TT) // recupere valeur des conditions et cf
        {
            this.tabTT = TT;
            this.iniTabT();
        }

    }

}
