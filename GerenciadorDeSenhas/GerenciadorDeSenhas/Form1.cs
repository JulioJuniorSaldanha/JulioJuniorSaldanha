using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GerenciadorDeSenhas
{
    public partial class fmrTela : Form
    {
        private string x = "";
        Thread t1;
        public fmrTela()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxbSenha.Clear();
            txbLogin.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle c = new Controle();
            String usuario=txbLogin.Text;
            String senha = TxbSenha.Text;


            string[] dados = c.buscaUsuario(c.criptografar(usuario));

            if (dados[1].Equals(c.criptografar(usuario)) && dados[2].Equals(c.criptografar(senha)))
            {
                
                MessageBox.Show("Autenticado com sucesso");
                x = usuario;
                
                this.Close();
                t1 = new Thread(usuarioAutenticado);                   
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else if(dados[0].Equals(null))
            {
                MessageBox.Show("Usuario ou senha incorertos");
            }
            else MessageBox.Show("Usuario ou senha incorertos");

        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirjanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void usuarioAutenticado()
        {
            Application.Run(new Tela_principal(x));
        }



        private void abrirjanela(object obj)
        {
            Application.Run(new FormCadastrar());
        }
    }
}