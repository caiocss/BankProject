using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class Conta
    {
        
        public Cliente titular{ get; set; }
        public int Numero{ get; set; }
        public double Saldo { get; private set; }

        //Metodo para Deposito
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
        }

        //Metodo para Saque
        public bool Sacar(double valorSaque)
        {
            if(this.Saldo >= valorSaque)
            {
                this.Saldo -= valorSaque;
                return true;
            }
            return false;
        }

        //Metodo para transferencia
        public bool Transferir(Conta contaDepositante, double valorTransferencia)
        {
            bool sucess = this.Sacar(valorTransferencia);
            if (sucess)
            {
                contaDepositante.Depositar(valorTransferencia);
                return true;
            }
            return false;
                           
        }

    }
}
