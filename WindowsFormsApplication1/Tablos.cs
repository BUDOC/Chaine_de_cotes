using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   class Tablos
    {
        public cond[] TabCond = new cond[10];
        public cf[] TabCf = new cf[10];
        
        public void iniTabcf() //Tableau des cf vide
        {
            for (int i = 0; i <= 9; i++)
            {
                TabCf[i] = null;
            }
        }
        public void iniTabCond() //Tableau des condition vide
        {
            for (int i = 0; i <= 9; i++)
            {
                TabCond[i] = null;
            }
        }
        public void chargePourTest()// charge des valeurs pour tester l'algo
        {            
           // cond C= new cond("C1", 3, 4, 50f, 1f); //la condition
            cond Cx =new cond();
            Cx.condName="c1";
            Cx.conditionOrigine=3;
            Cx.conditionExtremite=4;
            Cx.conditionCmoy=50f;
            Cx.conditionIT=1f;
            TabCond[0] = Cx;

            cf cf=new cf("cf1",4,5,20.1f,0.2f,0.3f);
            TabCf[0] = cf;
            cf = new cf(); //Création d'un nouveau pointeur pour pouvoir avoir un pointeur différent dans le tableau'
            cf.Name= "cf2"; //====            
            cf.Origine = 1;
            cf.Extremite = 3;
            cf.CoteMoyenne= 16f;
            cf.DipersionOrigine=0.1f;
            cf.DipersionExtremite=0.2f;
            TabCf[1] = cf;
            cf = new cf(); //Création d'un nouveau pointeur pour pouvoir avoir un pointeur différent dans le tableau'
            cf.Name = "cf3";
            cf.Origine = 5;
            cf.Extremite = 6;
            cf.CoteMoyenne=15f;
            cf.DipersionOrigine=0.1f;
            cf.DipersionExtremite=0.2f;
            TabCf[2] = cf;
            cf = new cf(); //Création d'un nouveau pointeur pour pouvoir avoir un pointeur différent dans le tableau'
            cf.Name = "cf4";
            cf.Origine = 0;
            cf.Extremite = 1;
            cf.CoteMoyenne = 14f;
            cf.DipersionOrigine = 0.1f;
            cf.DipersionExtremite = 0.2f;
            TabCf[3] = cf;
            cf = new cf(); //Création d'un nouveau pointeur pour pouvoir avoir un pointeur différent dans le tableau'
            cf.Name = "cf5";
            cf.Origine = 0;
            cf.Extremite = 6;
            cf.CoteMoyenne = 50f;
            cf.DipersionOrigine = 0.1f;
            cf.DipersionExtremite = 0.2f;
            TabCf[4] = cf;
            cf = new cf(); //Création d'un nouveau pointeur pour pouvoir avoir un pointeur différent dans le tableau'
            cf.Name = "cf6";
            cf.Origine = 4;
            cf.Extremite = 7;
            cf.CoteMoyenne = 18f;
            cf.DipersionOrigine = 0.1f;
            cf.DipersionExtremite = 0.2f;
            TabCf[5] = cf;
            cf = new cf(); //Création d'un nouveau pointeur pour pouvoir avoir un pointeur différent dans le tableau'
            cf.Name = "cf7";
            cf.Origine = 2;
            cf.Extremite = 4;
            cf.CoteMoyenne = 25f;
            cf.DipersionOrigine = 0.1f;
            cf.DipersionExtremite = 0.2f;
            TabCf[6] = cf;
            cf = new cf(); //Création d'un nouveau pointeur pour pouvoir avoir un pointeur différent dans le tableau'
            cf.Name = "cf8";
            cf.Origine = 3;
            cf.Extremite = 8;
            cf.CoteMoyenne = 22f;
            cf.DipersionOrigine = 0.1f;
            cf.DipersionExtremite = 0.2f;
            TabCf[7] = cf;           
        }
    }
 
}
