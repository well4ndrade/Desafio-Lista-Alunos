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
            Console.WriteLine("Bem-Vindo(a) ao programa de avaliação de alunos\n");

            Console.WriteLine("Digite a quantidade de alunos que deseja registrar:");
            int alunos = Convert.ToInt32(Console.ReadLine());

            List<dynamic> boletins = new List<dynamic>();

            for (int i = 1; i <= alunos; i++)
            {
                Console.WriteLine($"\nDigite o nome do {i}° aluno(a):");
                string name = Console.ReadLine();

                Console.WriteLine($"\nDigite a matrícula do {i}° aluno(a):");
                int mat = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPrimeira nota do aluno(a):");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Segunda nota do aluno(a):");
                double n2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Terceira nota do aluno(a):");
                double n3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Quarta nota do aluno(a):");
                double n4 = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                double med = (n1 + n2 + n3 + n4) / 4;
                string situacao = med >= 7 ? "Aprovado" : "Reprovado";

                boletins.Add(new
                {
                    Nome = name,
                    Matricula = mat,
                    Notas = new List<double>() {n1, n2, n3, n4},
                    Media = med,
                    Situacao = situacao
                });

            }

            Console.WriteLine("Segue a lista dos alunos:");
            Console.WriteLine("------------------------------------");

            foreach (var lista in boletins)
            {
                Console.WriteLine($"Nome: {lista.Nome}");
                Console.WriteLine($"Matrícula: {lista.Matricula}");
                Console.WriteLine($"Notas: {string.Join(", ", lista.Notas.ToArray())}");
                Console.WriteLine($"Média: {lista.Media}");
                Console.WriteLine($"Situação: {lista.Situacao}");
                Console.WriteLine("------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
