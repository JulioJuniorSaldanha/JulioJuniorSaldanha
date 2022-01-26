using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeSenhas
{
    internal class User
    {
        public string usuario;
        private string senha;
        private string nome;        
      
        public User(string n, string u,string s)
        { 
            nome = n;
            usuario = u;
            senha = s;      
        }
        public User(string u,String n)
        {
            usuario=u;
            nome = n;
            
        }

        public string getNome() { return nome; }






        public string Usuario { get { return usuario; } }
        
        public string Nome { get { return nome; } }


    }
}
