using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUnip
{
    public class ContaCorrente
    {
        private bool IsNullOrEmpty;

        // precisa ter 
        public string Nome { get; set; }
        public int ContaNumero { get; set; }
        public string AgenciaNumero { get; set; }
        private double Saldo { get; set; }


        public double saldo
        {
            get
            {
                return Saldo;
            }
            set 
            {
                if (value < 0)
                {
                    return;
                }
                Saldo = value;
            }
        }
        
        //public ContaCorrente(string nome,int contaNumero, string agenciaNumero)
        //{
        //    this.Nome = nome;
        //    this.AgenciaNumero = agenciaNumero;
        //    this.ContaNumero = contaNumero;
            
        //}
        public bool Sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                
                return false;
                
            }
            else
            {
                this.Saldo -= valor;
                return true;
            }
            
        }
        
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
         public bool VerificaArgumentos(ContaCorrente contaCorrente)
        {
            if (Nome=="" || ContaNumero.ToString()=="" || AgenciaNumero.ToString()=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
