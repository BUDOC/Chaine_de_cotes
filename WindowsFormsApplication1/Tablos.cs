using System;

namespace WindowsFormsApplication1
{
    class Tablos
    {
        public Cond[] TabCond = new Cond[10];
        public Cf[] TabCf = new Cf[10];

        public void iniTabcf()
        {
            for (int i = 0; i <= 9; i++)
            {
                TabCf[i] = null;
            }
        }

        public void iniTabCond()
        {
            for (int i = 0; i <= 9; i++)
            {
                TabCond[i] = null;
            }
        }

        public void chargePourTest()
        {
            Cond Cx = new Cond();
            Cx.Name = "c1";
            Cx.Origine = 3;
            Cx.Extremite = 4;
            Cx.Cmoy = 50f;
            Cx.IT = 1f;
            TabCond[0] = Cx;

            Cf cf = new Cf("cf1", 4, 5, 20.1f, 0.2f, 0.3f);
            TabCf[0] = cf;

            cf = new Cf();
            cf.Name = "cf2";
            cf.Origine = 1;
            cf.Extremite = 3;
            cf.CoteMoyenne = 16f;
            cf.DlOrigine = 0.1f;
            cf.DlExtremite = 0.2f;
            TabCf[1] = cf;

            cf = new Cf();
            cf.Name = "cf3";
            cf.Origine = 5;
            cf.Extremite = 6;
            cf.CoteMoyenne = 15f;
            cf.DlOrigine = 0.1f;
            cf.DlExtremite = 0.2f;
            TabCf[2] = cf;

            cf = new Cf();
            cf.Name = "cf4";
            cf.Origine = 0;
            cf.Extremite = 1;
            cf.CoteMoyenne = 14f;
            cf.DlOrigine = 0.1f;
            cf.DlExtremite = 0.2f;
            TabCf[3] = cf;

            cf = new Cf();
            cf.Name = "cf5";
            cf.Origine = 0;
            cf.Extremite = 6;
            cf.CoteMoyenne = 50f;
            cf.DlOrigine = 0.1f;
            cf.DlExtremite = 0.2f;
            TabCf[4] = cf;

            cf = new Cf();
            cf.Name = "cf6";
            cf.Origine = 4;
            cf.Extremite = 7;
            cf.CoteMoyenne = 18f;
            cf.DlOrigine = 0.1f;
            cf.DlExtremite = 0.2f;
            TabCf[5] = cf;

            cf = new Cf();
            cf.Name = "cf7";
            cf.Origine = 2;
            cf.Extremite = 4;
            cf.CoteMoyenne = 25f;
            cf.DlOrigine = 0.1f;
            cf.DlExtremite = 0.2f;
            TabCf[6] = cf;

            cf = new Cf();
            cf.Name = "cf8";
            cf.Origine = 3;
            cf.Extremite = 8;
            cf.CoteMoyenne = 22f;
            cf.DlOrigine = 0.1f;
            cf.DlExtremite = 0.2f;
            TabCf[7] = cf;
        }
    }
}
