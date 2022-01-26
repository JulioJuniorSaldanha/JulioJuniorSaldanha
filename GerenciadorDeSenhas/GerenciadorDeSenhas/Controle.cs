using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace GerenciadorDeSenhas
{
    public class Controle   
    {
        const string documento = @"C:\Arquivos de Programas Safeweb\gerenciador de senhas\Users.txt";

        //Método para criar um novo usuario
        public void cadastraUsuario(string n, string u, string s)
        {
            using (StreamWriter sw = File.AppendText(documento)) {

                sw.WriteLine( criptografar(n) + ";" + criptografar(u) + ";" + criptografar(u));
                
                MessageBox.Show("Usuario cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }

        //Método de pesquisa de usuarios
        public string[] buscaUsuario(string s)
        {
            using (StreamReader sr = new StreamReader(documento)) {
                while (!sr.EndOfStream)
                {
                    var pathline = sr.ReadLine();
                    string[] x= pathline.Split(';');
                    if (x[1].Equals(s))
                    {
                        string[] dadolinha = pathline.Split(';');
                        User u = new User(x[0], x[1], x[2]);                       
                        return dadolinha;
                       
                    }                 
                     
                }
                MessageBox.Show("Usuario não encontrado","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;

            }             
        }

        public string criptografar(string t)
        {
            try
            {
                string txttoEncrypt = t;
                string resultado = "";
                string chavepublica = "12345678";
                string chaveprivada = "87654321";
                byte[] bytechaveprivada = { };
                bytechaveprivada = System.Text.Encoding.UTF8.GetBytes(chaveprivada);
                byte[] bytechavepublica = { };
                bytechavepublica = System.Text.Encoding.UTF8.GetBytes(chavepublica);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(txttoEncrypt);
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(bytechavepublica, bytechaveprivada), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    resultado = Convert.ToBase64String(ms.ToArray());
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }


    }

    }
      


