using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisinha_Matlugo
{
    internal class contatos
    {
        private string primeiroNome;
        private string sobrenome;
        private string telefone;
    
    //PROPRIEDADES (GET e SET)
    public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
    public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Tlefone
        { 
            get { return telefone; } 
            set { 
                if (value.Length == 11)
                
                    telefone = value;
                }
                else
                {
                    telefone = "00-00000-0000"
                }
            
            }


        public contatos()
        {
        PrimeiroNome = "José"
        Sobrenome = "Da Silva"
        Telefone = "11-98506-6969"
        }
        
        public contatos(string primeironome, string sobrenome, string telefone)
        { primeiroNome = primeironome;
        Sobrenome = sobrenome;
        Telefone = telefone
                }

        public override string ToString()
        {
            string saida = String.Empty;
        }









    }


}
