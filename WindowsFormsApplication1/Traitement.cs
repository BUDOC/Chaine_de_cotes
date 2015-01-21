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
        cf[] TabCfT = new cf[10];
        cond[] TabCondT = new cond[10];

        public void iniTabT() //Tableau TABT vide
        {
            this.Tabt = null;
        }
        public void SetValeurTabT(Tablos TT)
        {
            this.TabCfT = TT.TabCf;
            this.TabCondT = TT.TabCond;
        }
    }

}
