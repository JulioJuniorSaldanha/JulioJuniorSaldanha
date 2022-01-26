using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeSenhas
{
    public partial class Tela_principal : Form
    {
        private string usu;
       Servico s = new Servico();
       Controle c = new Controle();

        public Tela_principal(string y)
        {
            usu = y;
            
            InitializeComponent();           
            using (StreamReader sr = new StreamReader(@"C:\Arquivos de Programas Safeweb\gerenciador de senhas\Service.txt"))
                while (!sr.EndOfStream)
                {
                    var pathline = sr.ReadLine();
                    
                    string[] x = pathline.Split(';');
                    if (x[5].Equals(usu))
                    {                   
                       ListViewItem lv  = new ListViewItem(x);
                        lvServicos.Items.Add(lv);

                    } 
                    

                }
            lblUsuario.Text = "Seja bem vindo\n"+ usu;
            
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadatrarServico cadatrarServico = new CadatrarServico(usu);
            cadatrarServico.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string s0,s1, s2, s3, s4;

            s0 = lvServicos.SelectedItems[0].SubItems[0].Text;
            s1 = lvServicos.SelectedItems[0].SubItems[1].Text;
            s2 = lvServicos.SelectedItems[0].SubItems[2].Text;
            s3 = lvServicos.SelectedItems[0].SubItems[3].Text;
            s4 = lvServicos.SelectedItems[0].SubItems[4].Text;

            using (StreamReader sr = new StreamReader(@"C:\Arquivos de Programas Safeweb\gerenciador de senhas\Service.txt"))

                while (!sr.EndOfStream)
                {
                    var pathline = sr.ReadLine();

                    string[] x = pathline.Split(';');
                    if (x[1].Equals(s1) && x[2].Equals(s2) && x[3].Equals(s3) && x[4].Equals(s4))
                    {
                        CadatrarServico cs = new CadatrarServico(usu,s0, s1, s2, s3, s4);
                        cs.Show();

                    }            
                }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string x = lvServicos.SelectedIndices[0].ToString();
            MessageBox.Show(x,"");
            int y = int.Parse(x);
            s.excluir(y);
           // lvServicos.Items.RemoveAt(lvServicos.SelectedIndices[0]);

        }

        private void lstServiços_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lvServicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            lvServicos.Items.Clear();
            using (StreamReader sr = new StreamReader(@"C:\Arquivos de Programas Safeweb\gerenciador de senhas\Service.txt"))
                while (!sr.EndOfStream)
                {
                    var pathline = sr.ReadLine();

                    string[] x = pathline.Split(';');
                    if (x[5].Equals(usu))
                    {
                        ListViewItem lv = new ListViewItem(x);
                        lvServicos.Items.Add(lv);

                    }


                }

        }
    }
}
