using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinoPOOHeranca.obj;

namespace TreinoPOOHeranca.Models
{
    public class Iphone : Smartphone
    {
        public Iphone() : base () {} // Construtor vazio herdado herdado da classe Abstrata Smartphone

        public Iphone (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria) 
        {

        }     

        public override void InstalarAplicativo(string nomeDoApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeDoApp} na Loja da Apple ");
        }
    }
}