using System;

namespace WindowsFormsApplication1
{
    public class Cond
    {
        // Propriétés publiques pour une condition
        public string Name { get; set; }
        public int Origine { get; set; }
        public int Extremite { get; set; }
        public float Cmoy { get; set; }
        public float IT { get; set; }

        public Cond() { }

        public Cond(string name, int origine, int extremite, float cmoy, float it)
        {
            Name = name;
            Origine = origine;
            Extremite = extremite;
            Cmoy = cmoy;
            IT = it;
        }
    }

    public class Cf
    {
        // Propriétés publiques pour un couple de fonction (cf)
        public string Name { get; set; }
        public int Origine { get; set; }
        public int Extremite { get; set; }
        public bool Traite { get; set; }
        public float IT { get; set; }
        public float CoteMoyenne { get; set; }
        public float DlOrigine { get; set; }
        public float DlExtremite { get; set; }

        public Cf() { }

        public Cf(string name, int origine, int extremite, float cmoy, float dlOrigine, float dlExtremite)
        {
            Name = name;
            Origine = origine;
            Extremite = extremite;
            CoteMoyenne = cmoy;
            DlOrigine = dlOrigine;
            DlExtremite = dlExtremite;
        }
    }
}
