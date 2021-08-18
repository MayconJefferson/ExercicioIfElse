using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string aluno;
            int nota1, nota2, media;

            Console.WriteLine("Digite o nome do aluno:");
            aluno = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota do " + aluno);
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do " + aluno);
            nota2 = Convert.ToInt32(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if(media == 0) 
            {
                Console.WriteLine(aluno + ", você não aprendeu nada!");

            }
            else if (media >= 1 && media <= 4)
            {
                Console.WriteLine(aluno + " você está reprovado!");

            }
            else if (media >= 5 && media <= 7)
            {

                Console.WriteLine(aluno + " você passou raspando.");
            }
            else if (media >= 8 && media <= 9) 
            {

                Console.WriteLine(aluno + " você mandou bem.");
            }
            else if (media == 10)
            {
                Console.WriteLine(aluno + "Parabéns, você é muito inteligente!");
            }
            Console.Read();
            */

            

            Console.WriteLine("Digite qual a tabuada:");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=10; i++)
            {
                Console.Write($"{numero} x {i} = {numero * i}");
                Console.Write("\n");
                
            }
            Console.Read();
            
        }
    }
}
