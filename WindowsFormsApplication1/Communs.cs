﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  
    public class cond //declaration
    {
       string nom;   // déclaration des variables publiques
        public int condOrigine;
         int condExtremite;
         float ITcond;
         float cmoycond;

        public cond(string n, int o, int e, float cmoy, float IT) // constructeur  des conditions  
        {
            nom = n;
            condOrigine = o;
            condExtremite = e;          
            ITcond = IT;
            cmoycond = cmoy;
        }
        public cond()
        {
            //constructeur vide
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

        public cf() // constructeur vide
        {
        }
        
        public cf(string nomcf, int cfO, int cfE, float cmoy, float DlO, float DlE) // constructeur Cf
        {
            cfname = nomcf;
            cfOrigine = cfO;
            cfExtremite = cfE;                  
            cfCmoy = cmoy;
            cfDlOrigine = DlO;
            cfDlExtremite = DlE;              
        }
        //============= getteurs et setteurs de conditions =============
        public string Name
        {
            get { return cfname; }
            set { cfname= value; }
        }
        public int Origine
        {
            get { return cfOrigine; }
            set { cfOrigine = value; }
        }
        public int Extremite
        {
            get { return cfExtremite; }
            set { cfExtremite = value; }
        }
        public float CoteMoyenne
        {
            get { return cfCmoy; }
            set { cfCmoy = value; }
        }
        public float DipersionOrigine
        {
            get { return cfDlOrigine; }
            set { cfDlOrigine = value; }
        }
        public float DipersionExtremite
        {
            get { return cfDlExtremite; }
            set { cfDlExtremite = value; }
        }
    }

   
        
        
    }









