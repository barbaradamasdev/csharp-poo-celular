using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOOCelular.Models
{
    public abstract class Smartphone
    {
        public string Numero {get; set;}
        private string Modelo;
        private string IMEI;
        private int Memoria;


        public Smartphone (string numero, string modelo, string imei, int memoria) {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        
        public void Ligar(){
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligacao...");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}