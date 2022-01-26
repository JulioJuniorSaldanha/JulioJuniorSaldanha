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
    public partial class FormCadastrar : Form
    {
        Thread t1;
        
        public FormCadastrar()
        {
            InitializeComponent();
            txbNome.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();          
            txblogin.Clear();            
            txbSenha.Clear();     
            txbConfsenha.Clear();
            txbNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string login = txblogin.Text;
            string senha = txbSenha.Text;
            string conf = txbConfsenha.Text;

        if(senha == conf && nome != "" && login != "")
            {
                Controle c = new Controle();

                c.cadastraUsuario(nome, login, senha);
                txbNome.Focus();

               
               
         }else{
               MessageBox.Show("Erro ao cadatrar verifique se as senhas conferem e se não deixou nenhum dado em branco","Erro", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                
        }



        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            

        }
            

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirjanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirjanela()
        {
            Application.Run(new fmrTela());
        }
    }
}
