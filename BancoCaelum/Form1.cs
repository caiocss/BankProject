using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoCaelum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaCaio = new Conta();

            contaCaio.Numero = 1;
            contaCaio.titular = new Cliente("Caio");            
            contaCaio.titular.Idade = 29;
            contaCaio.Depositar(100);

            Conta contaJoao = new Conta();

            contaJoao.Numero = 2;
            contaJoao.titular = new Cliente("João");            
            contaJoao.titular.Idade = 17;
            contaJoao.Depositar(200);

            bool transferWork = contaJoao.Transferir(contaCaio, 250);

            if (transferWork)
                MessageBox.Show($"Transferencia realizada com sucesso, o seu saldo atual é de R${contaJoao.Saldo}");
            else
                MessageBox.Show($"Transferencia não realizada, o seu saldo atual é de R${contaJoao.Saldo}");

            MessageBox.Show($"Conta {contaJoao.titular.Nome}: R${contaJoao.Saldo}. Conta {contaCaio.titular.Nome}: R${contaCaio.Saldo}");

            if(contaCaio.titular.EhMaiorDeIdade())
                MessageBox.Show($"O correntista {contaCaio.titular.Nome} é maio de idade");


            Cliente novoCliente = new Cliente()
            {
                Nome = "Outro",
                Idade = 3,
            };
            
        }
    }
}
