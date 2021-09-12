using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasRevisaoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fabricação de instância
            //var aluno = new Aluno() { Nome = "Wesley", Matricula = "001" };    

            //var aluno2 = new Aluno();
            //aluno2.Nome = "Daniel";

            Console.WriteLine("Bem-Vindo(a) ao programa de avaliação de alunos\n");

            Console.Write("Digite a quantidade de alunos que deseja registrar: ");
            int alunos = Convert.ToInt32(Console.ReadLine());

            List<Aluno> boletins = new List<Aluno>();

            for (int i = 1; i <= alunos; i++)
            {
                var aluno = new Aluno();

                Console.Write($"\nDigite o nome do {i}° aluno(a): ");
                aluno.Nome = Console.ReadLine();
                Console.Write($"\nDigite a matrícula do {i}° aluno(a): ");
                aluno.Matricula = Console.ReadLine();
                Console.Write("\nPrimeira nota do aluno(a): ");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Segunda nota do aluno(a): ");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Terceira nota do aluno(a): ");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Quarta nota do aluno(a): ");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Clear();

                boletins.Add(aluno);
            }

            Console.WriteLine("Segue a lista dos alunos:");
            Console.WriteLine("------------------------------------");

            foreach (var lista in boletins)
            {
                Console.WriteLine(lista.ToString());
            }

            Console.ReadKey();
        }
    }
}
