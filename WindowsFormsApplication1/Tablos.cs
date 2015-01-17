using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Tablos
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
            cond C= new cond("C1", 3, 4, 50f, 1f); //la condition
            TabCond[0] = C;
            cf cf=new cf("cf1",4,5,20.1f,0.2f,0.3f);
            TabCf[0] = cf;
            cf.cfname = "cf2"; //====
            cf.cfOrigine = 3;
            cf.cfExtremite = 1;
            cf.cfCmoy = 15;            
            TabCf[1] = cf;
            cf.cfname = "cf3"; //====
            cf.cfOrigine = 5;
            cf.cfExtremite = 6;
            cf.cfCmoy = 15;
            TabCf[2] = cf;
            cf.cfname = "cf4"; //====
            cf.cfOrigine = 0;
            cf.cfExtremite = 1;
            cf.cfCmoy = 15.2f;
            TabCf[3] = cf;
            cf.cfname = "cf5"; //====
            cf.cfOrigine = 0;
            cf.cfExtremite = 6;
            cf.cfCmoy = 15;
            TabCf[4] = cf;
            cf.cfname = "cf6"; //====
            cf.cfOrigine = 7;
            cf.cfExtremite = 7;
            cf.cfCmoy = 15;
            TabCf[5] = cf;
            cf.cfname = "cf7"; //====
            cf.cfOrigine = 2;
            cf.cfExtremite = 4;
            cf.cfCmoy = 15;
            TabCf[6] = cf;
            cf.cfname = "cf8"; //====
            cf.cfOrigine = 3;
            cf.cfExtremite = 8;
            cf.cfCmoy = 15;
            TabCf[7] = cf;
        }
    }
 
}
