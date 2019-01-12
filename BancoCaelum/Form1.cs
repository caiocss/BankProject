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
            contaCaio.titular = new Cliente();
            contaCaio.titular.nome = "Caio";
            contaCaio.titular.idade = 29;
            contaCaio.Deposita(100);

            Conta contaJoao = new Conta();

            contaJoao.Numero = 2;
            contaJoao.titular = new Cliente();
            contaJoao.titular.nome = "João";
            contaJoao.titular.idade = 17;
            contaJoao.Deposita(200);

            bool transferWork = contaJoao.Transfere(contaCaio, 250);

            if (transferWork)
                MessageBox.Show($"Transferencia realizada com sucesso, o seu saldo atual é de R${contaJoao.Saldo}");
            else
                MessageBox.Show($"Transferencia não realizada, o seu saldo atual é de R${contaJoao.Saldo}");

            MessageBox.Show($"Conta {contaJoao.titular.nome}: R${contaJoao.Saldo}. Conta {contaCaio.titular.nome}: R${contaCaio.Saldo}");

            if(contaCaio.titular.EhMaiorDeIdade())
                MessageBox.Show($"O correntista {contaCaio.titular.nome} é maio de idade");
            
            
        }
    }
}
