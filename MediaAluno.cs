using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3





{




public class Aluno 
        { 
            
        
            public String Materia { get; set; }
            public String Ra { get; set; }
            public String Nome { get; set; } 
            public double p1 { get; set; }
            public double p2 { get; set; }
            public double media { get; set; }
        } 




    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.Write("\nDigite o nome do aluno: ");
            
            aluno.Nome = Console.ReadLine();

            Console.Write("\nDigite o RA do Aluno: ");
            
            aluno.Ra = Console.ReadLine();           

            Console.Write("\nDigite a Materia do aluno: ");
            
            aluno.Materia = Console.ReadLine();

            Console.Write("\nDigite a primeira nota do aluno: ");

            aluno.p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite a segunda nota do Aluno: ");

            aluno.p2 = Convert.ToDouble(Console.ReadLine());;


            aluno.media = (aluno.p1 + aluno.p2) / 2;    
            

            if(aluno.media >= 6) {
             Console.Write("\nAluno Aprovado");

            }else{


             Console.Write("\nAluno Reprovado");
                
            }

            Console.Write("\n***************************************************************************");
            Console.Write("\nNome: {0} \tMateria: {1} \tR.A: {2}", aluno.Nome, aluno.Materia, aluno.Ra);
            Console.Write("\nNotas: \tP1: {0} \tP2: {1} \tMédia: {2}", aluno.p1, aluno.p2, aluno.media);
            
            
            
            Console.Write("\nDigite qualquer tecla para sair....");
            Console.ReadKey();





        }
    }
}
