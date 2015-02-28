using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms; // ajouté pour avoir acces à MessageBox


namespace WindowsFormsApplication1
{

    class Traitement
    {
        public int[,] Tabt = new int[10, 10];
        int[,] TabDesNiveaux = new int[10, 15];
        public Tablos tabTT = new Tablos();
        public int[] origine = new int[10];
        public int[] extremite = new int[10];
        public int[] tabcolcf = new int[10];
        public int nbliTabt = 0;
        public int nbcoTabt = 0;
        public bool ferme = true;
 string nomfic = "Texte.txt";
        public Traitement() //constructeur vide
        {
        }
       
        public void ecritResult(string info) // stocke les résulats dans un fichier texte
        {
            string blancs = " ";
          //  string nomfic = "Texte.txt";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(nomfic,true)) //sans @ =fichier dans répertoire courant                        
                {                    
                    string line = "";
                    file.WriteLine("Tableau Tabt  "+info);
                    for (int j = 0; j < 10; j++)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if (this.Tabt[j, i]<0)
                            {
                                blancs = "  ";
                            }
                            else
                            {
                                blancs = "   ";
                            }
                            line = line + blancs + this.Tabt[j, i].ToString("0.");
                        }
                        line = line + "\n";
                        file.WriteLine(line);
                        line = "";
                    }
                    file.WriteLine("Tableau TabDEsNiveaux");
                    for (int j = 0; j < 10; j++)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            if (this.TabDesNiveaux[j, i] < 0)
                            {
                                blancs = "  ";
                            }
                            else
                            {
                                blancs = "   ";
                            }
                            line = line + blancs + this.TabDesNiveaux[j, i].ToString("0.");
                        }
                        line = line + "\n";
                        file.WriteLine(line);
                        line = "";
                    }
                    
                }                          
        }
        public void iniTabT() //Tableau TABT vide
        {
            nbliTabt = Tabt.GetUpperBound(0);
            nbcoTabt = Tabt.GetUpperBound(1);
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
            MessageBox.Show("Init tableau OK et recherche couple 3 4");
            cherche(3, 4);
        }
        private void initTabcolcf()
        {
            int b = this.tabcolcf.GetUpperBound(0);
            for (int i = 0; i <= b; i++)
            {
                this.tabcolcf[i] = -1;
            }
        }
        public bool ok = false;
        public void cherche(int o, int e) //====================================================================================================
        {
            int colScrutte = 0;
            int ligneScrute = 0;
            int cpt = 0;
            int nivo = 0;
            int pos = 0;
            int pos2 = 0;
            int co = this.Tabt.GetUpperBound(1);
            int li = this.Tabt.GetUpperBound(0);
            cf Cfr = new cf();
            Cfr = new cf();
            // a faire tant que l'extremité de la condition n'est pas trouvée dans une borne de cf (OK=true) ou qu'il n'y ait plus de cf à exploiter (pb cotation)
            pos = PremiereLigne(o, e, nivo, pos, co);
            //tester si ok = TRUE
         
            while (this.ok == false || this.ferme == false)
            {
                initTabcolcf();            
                pos2 = 0;
                nivo = nivo + 1;
                initTabcolcf();
                cpt = 0;
                Colonnes(e, ref colScrutte, ref cpt, nivo, ref pos2);
                nivo = nivo + 1;
                //lignes suivantes
                AutreLigne(e, ref ligneScrute, ref cpt, nivo, pos, ref pos2);
            }
        }

        public int passage = 0;
        private void AutreLigne(int e, ref int ligneScrute, ref int cpt, int nivo, int pos, ref int pos2)
        {
            passage = passage + 1;
            cpt = 0;
           // MessageBox.Show("entrée Autre ligne   Passage="+passage.ToString());
            while (this.TabDesNiveaux[nivo - 1, cpt] != -1)
            {
                ligneScrute = this.TabDesNiveaux[nivo - 1, cpt];
                for (int i5 = 0; i5 <= this.nbcoTabt; i5++)
                {
                    if (this.Tabt[cpt, i5] != -1)
                    {
                        this.TabDesNiveaux[nivo, pos] = i5;//  rentre les n° de lignes trouvées dans le tableau des niveau  "nivo"                      
                        this.tabcolcf[pos2] = this.Tabt[cpt, i5]; // rente les n°  cf est trouvée
                        pos2 = pos2 + 1;
                        if (this.tabTT.TabCf[this.Tabt[cpt, i5]].Extremite == e || this.tabTT.TabCf[this.Tabt[cpt, i5]].Origine == e) // Un lien avec l'extrémité de condition est trouvé : la chaine est bouclée
                        {
                            ok = true;
                        }
                        this.Tabt[i5, cpt] = -1; // efface les cf trouvées sur la ligne ainsi que leurs symétrique par rapport à la diagonale *********
                        this.Tabt[cpt, i5] = -1;
                    }
                }
                cpt = cpt + 1;
            }
            if (pos2 == 0) //plus de cotes donc il y a une erreur sur les données d'entrées : la chaine ne peut pas fermer
            {
                this.ferme = false;
            }
            ecritResult( "Autre ligne Passage : "+passage.ToString());
         //   MessageBox.Show("Sortie Autre ligne ");
        }

        private void Colonnes(int e, ref int colScrutte, ref int cpt, int nivo, ref int pos2)
        {
           // MessageBox.Show("entrée Colonnes");
            while (this.TabDesNiveaux[nivo - 1, cpt] != -1)
            {
                colScrutte = this.TabDesNiveaux[nivo - 1, cpt];
                for (int i4 = 0; i4 <= this.nbliTabt; i4++)
                {
                    if (this.Tabt[i4, cpt] != -1)
                    {
                        this.TabDesNiveaux[nivo, pos2] = i4;//  rentre les n° de lignes trouvées dans le tableau des niveau  "nivo"                      
                        this.tabcolcf[pos2] = this.Tabt[i4, cpt]; // rente les n°  cf est trouvée
                        pos2 = pos2 + 1;
                        if (this.tabTT.TabCf[this.Tabt[i4, cpt]].Extremite == e || this.tabTT.TabCf[this.Tabt[i4, cpt]].Origine == e) // Un lien avec l'extrémité de condition est trouvé : la chaine est bouclée
                        {
                            ok = true;
                        }
                        this.Tabt[i4, cpt] = -1; // efface les cf trouvées sur la ligne ainsi que leurs symétrique par rapport à la diagonale *********
                        this.Tabt[cpt, i4] = -1;
                    }
                }
                cpt = cpt + 1;
            }
            if (pos2 == 0) //plus de cotes donc il y a une erreur sur les données d'entrées : la chaine ne peut pas fermer
            {
                this.ferme = false;
            }
            ecritResult("Colonnes");
          //  MessageBox.Show("Sortie colonnes");

        }

        private int PremiereLigne(int o, int e, int nivo, int pos, int co)
        {
           // MessageBox.Show("entrée Premiere ligne");
            ecritResult("Avant traitement");
            for (int i = 0; i < co; i++) // trouve les cf qui sont en relation avec l'origine de la condition
            {
                if (this.Tabt[o, i] != -1)
                {
                    this.TabDesNiveaux[nivo, pos] = i; // rentre les n° de colonnes trouvées dans le tableau des niveau  "nivo"
                    pos = pos + 1;
                    this.tabcolcf[pos] = this.Tabt[o, i]; // rente les n°  cf est trouvée
                    if (this.tabTT.TabCf[this.Tabt[o, i]].Extremite == e || this.tabTT.TabCf[this.Tabt[o, i]].Origine == e) // Un lien avec l'extrémité de condition est trouvé : la chaine est bouclée
                    {
                        ok = true;
                    
                    }
                    this.Tabt[o, i] = -1; // efface les cf trouvées sur la ligne ainsi que leurs symétrique par rapport à la diagonale *********
                    this.Tabt[i, o] = -1;
                }
            }
          //  MessageBox.Show("Sortie Premiere ligne");
            ecritResult("Première ligne");
            return pos;
        }

        public void SetValeurTabT(Tablos TT) // recupere valeur des conditions et cf
        {
            this.tabTT = TT;
            this.iniTabT();
        }

    }

}
