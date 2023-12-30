using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBD
{
    public class PozycjaFaktury
    {
        public string Lp {  get; set; }
        public string Usluga { get; set; } 
        public string Jm { get; set; }
        public float Ilosc {  get; set; }
        public float CenaJednostkowa { get; set; }
        public float WartoscNetto { get; set; }
        public int ProcentVat {  get; set; }
        public float WartoscVat { get; set; }
        public float WartoscBrutto { get; set; }
    }
}
