using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GerenciadorDeSenhas
{
    public partial class CadatrarServico : Form
    {
        private String usuario;
        Servico s = new Servico();
        private string ID;

        public CadatrarServico(string  u)
        {
            InitializeComponent();
            usuario = u;
            txbID.Text = s.buscaservicos(usuario).ToString();
        }

        public CadatrarServico(string u,string s0,string s1, string s2, string s3, string s4)
        {
            InitializeComponent();
            usuario = u;
            txbID.Text = s0;
            txbNome.Text = s1;
            txbLoginSer.Text = s2;
            txbSenhaSer.Text = s3;
            txbLink.Text = s4;
            btnCadastrar.Text = "atualizar";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbLink.Clear();
            txbLoginSer.Clear();
            txbSenhaSer.Clear();
            txbID.Text = s.buscaservicos(usuario).ToString();


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            if (txbNome.Text == "")
            {
                MessageBox.Show("O campo 'Nome' não foi preenchido por favor preencha todos os campos", "Preencha todos os campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txbNome.Focus();

            }
            else if (txbLink.Text == "")
            {
                MessageBox.Show("O campo 'Link' não foi preenchido por favor preencha todos os campos", "Preencha todos os campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txbLink.Focus();
            }
            else if (txbLoginSer.Text == "")
            {
                MessageBox.Show("O campo 'Login do serviço' não foi preenchido por favor preencha todos os campos", "Preencha todos os campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txbLoginSer.Focus();
            }
            else if (txbSenhaSer.Text == "")
            {
                MessageBox.Show("O campo 'Senha do serviço' não foi preenchido por favor preencha todos os campos", "Preencha todos os campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txbSenhaSer.Focus();
            }
            ////else if(btnCadastrar.Text == "atualizar"){
            ////    using (StreamReader sr = new StreamReader(@"C:\Arquivos de Programas Safeweb\gerenciador de senhas\Service.txt"))

            ////        while (!sr.EndOfStream)
            ////        {
            ////            var pathline = sr.ReadLine();

            ////            string[] x = pathline.Split(';');
            //            if (x[0].Equals(txbID.Text) )
            //            {
                            
            //                s.cadastraServico(0,null,null, null, null, null);
            //                int num = int.Parse(x[0]);
            //                s.cadastraServico(num, x[1], x[2], x[3], x[4],usuario);
                            
            //            }
            //        }
            //}

            else
            {
                s.cadastraServico(int.Parse(txbID.Text), txbNome.Text, txbLoginSer.Text, txbSenhaSer.Text, txbLink.Text, usuario);
               

                txbNome.Clear();
                txbLink.Clear();
                txbLoginSer.Clear();
                txbSenhaSer.Clear();
                txbNome.Focus();
                txbID.Text = s.buscaservicos(usuario).ToString();
            }
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
