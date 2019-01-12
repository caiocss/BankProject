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
        public void Deposita(double valorDeposito)
        {
            this.Saldo += valorDeposito;
        }

        //Metodo para Saque
        public bool Saca(double valorSaque)
        {
            if(this.Saldo >= valorSaque)
            {
                this.Saldo -= valorSaque;
                return true;
            }
            return false;
        }

        //Metodo para transferencia
        public bool Transfere(Conta contaDepositante, double valorTransferencia)
        {
            bool sucess = this.Saca(valorTransferencia);
            if (sucess)
            {
                contaDepositante.Deposita(valorTransferencia);
                return true;
            }
            return false;
                           
        }

    }
}
