using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        
       
        public Pessoa(string nome){
            Nome = nome;
            
        }
        private string _nome;
        public string Nome 
        { 
            get =>_nome.ToUpper();
            

            set{
                if(value== ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        }

        public void Deconstruct(out string nome){
            nome = Nome;
            
        }
        
    }
}