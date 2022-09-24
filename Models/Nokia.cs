using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinoPOOHeranca.obj;

namespace TreinoPOOHeranca.Models
{
    public class Nokia : Smartphone
    {

        public string Modelo { get; set; }

        public Nokia() : base () {} // Construtor vazio herdado herdado da classe Abstrata Smartphone

        public Nokia (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria) 
        {
            Modelo = modelo;
        }       

        public override void InstalarAplicativo(string nomeDoApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeDoApp} na loja da Nokia ");
        }
    }
}