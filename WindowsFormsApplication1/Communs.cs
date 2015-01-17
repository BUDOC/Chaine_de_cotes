using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  
    public class cond //declaration
    {
        public string nom;   // déclaration des variables publiques
        public int condOrigine;
        public int condExtremite;
        public bool traite;
        public float ITcond;
        public float cmoycond;

        public cond(string n, int o, int e, float cmoy, float IT) // constructeur  des conditions  
        {
            nom = n;
            condOrigine = o;
            condExtremite = e;
          
            ITcond = IT;
            cmoycond = cmoy;
        }

        //============= getteurs et setteurs de conditions =============
        public string condName
        {
            get { return nom; }
            set { nom = value; }
        }
        public int conditionOrigine
        {
            get { return condOrigine; }
            set { condOrigine = value; }
        }
        public int conditionExtremite
        {
            get { return condExtremite; }
            set { condExtremite = value; }
        }
        public float conditionCmoy
        {
            get { return cmoycond; }
            set { cmoycond = value; }
        }
        public float conditionIT
        {
            get { return ITcond; }
            set { ITcond = value; }
        }
       
    }


    public class cf // declaration cf
    {
        public string cfname;
        public int cfOrigine;
        public int cfExtremite;
        public bool cfTraite;
        public float cfIT;
        public float cfCmoy;
        public float cfDlOrigine;
        public float cfDlExtremite;

        public cf(string nom, int cfO, int cfE, float cmoy, float DlO, float DlE) // constructeur Cf
        {
            cfname = nom;
            cfOrigine = cfO;
            cfExtremite = cfE;                  
            cfCmoy = cmoy;
            cfDlOrigine = DlO;
            cfDlExtremite = DlE;
        }



    }

   
        
        
    }









