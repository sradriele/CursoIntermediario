using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Programa
    {
        static void Main(string[] args) 
        {
            Aluno aluno1 = new Aluno();//Objeto
            aluno1.nome = "Adriele";
            aluno1.idade = 31;
            aluno1.email = "sradriele@gmail.com";
            aluno1.endereco = "Rua A,45";

            Professor professor1 = new Professor();
            professor1.nome = "Paulo";
            professor1.idade = 51;
            professor1.email = "paulo@gmail.com";
            professor1.endereco = "Rua A,45";
            professor1.disciplina = "Quimica";

            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.idade);
            Console.WriteLine(aluno1.email);
            Console.WriteLine(aluno1.endereco);

            aluno1.MostraOsDadosdeAlunonaTela();
            professor1.MostraOsDadosdeProfessorTela();
            
            
            Console.ReadKey();
        }
    }
}
