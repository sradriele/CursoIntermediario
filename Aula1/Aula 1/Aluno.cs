using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Aluno  //Classe Aluno
    {
        public string nome;// atributos 
        public int idade;
        public string email;
        public string endereco;
        public string matricula;

        public void MostraOsDadosdeAlunonaTela()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade:" + idade);
            Console.WriteLine("email" + email);
            Console.WriteLine("endereco" + endereco);
            Console.WriteLine("matricula" + matricula);
        }
        
    }
}
