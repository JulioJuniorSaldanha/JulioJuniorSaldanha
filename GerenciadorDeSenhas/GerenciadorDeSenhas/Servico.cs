using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeSenhas
{
    internal class Servico
    {
        private int ID;
        private string servico;
        private string usuario;
        private string senha;
        private string pertence;
        private string link;
        List<string> dados = new List<string>();

        const string path = @"C:\Arquivos de Programas Safeweb\gerenciador de senhas\Service.txt";

        public Servico(string ser, string u, string senha, string l)
        {
            this.servico = ser;
            this.usuario = u;
            this.senha = senha;
            this.link = l;
        }
        public Servico() { }

        public void cadastraServico(int id,string ser, string u, string senha, string l, string p)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(id + ";" + ser + ";" + u + ";" + senha + ";" + l + ";" + p);

                MessageBox.Show("Serviço cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.WriteLine();
            }
        }


        public List<string> buscaservico(String n)
        {

            using (StreamReader sr = new StreamReader(path))
            {

                while (!sr.EndOfStream)
                {

                    var x = sr.ReadLine();
                    string[] y = x.Split(';');

                    if (y[5].Equals(n))
                    {
                        dados.Add(x);

                    }

                }

                return dados;

            }
        }
        public int buscaservicos(String n)
        {
            int i = 0;
            using (StreamReader sr = new StreamReader(path))
            {

                while (!sr.EndOfStream)
                {

                    var x = sr.ReadLine();
                    string[] y = x.Split(';');

                    if (y[5].Equals(n))
                    {
                        i++;

                    }

                }
                return i;

            }
        }
    public void excluir(int i)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    var x = sr.ReadLine();
                    string[] y = x.Split(';');

                    if (y[0].Equals(i.ToString()))
                    {
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("");
                        return;
                    }
                }
            }
        }


    }
}
