using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoPOOHeranca.obj
{
    public abstract class Smartphone
    {
        public string NumeroTelefone { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }  
  
        public Smartphone() {} // Construtor vazio
        
        public Smartphone( string numero, string modelo, string imei, int memoria) { // Construtor com parametros acessores
            NumeroTelefone = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        } 

        public void FazerLigacao() //Metodo Ligar
        {
            Console.WriteLine("Faazendo Ligação.....");
        }

        public void ReceberLigacao() // Metodo Receber Ligaçao
        {
            Console.WriteLine("Recebendo Ligação....");
        }

        public abstract void InstalarAplicativo(string nomeDoApp); // metodo Abstrato Instalar aplcativos
    }
}