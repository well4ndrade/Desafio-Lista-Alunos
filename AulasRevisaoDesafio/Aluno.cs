using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasRevisaoDesafio
{
    class Aluno
    {
        //Construtores:
        /*
        public Aluno() { }
        public Aluno(string nome)
        {
            this.Nome = nome;
        }
        */

        //Atributo:
        //private int id; 

        //Propriedade:
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Matricula { get; set; }

        private List<double> notas;
        public List<double> Notas 
        {
            get 
            {
                if (this.notas == null) this.notas = new List<double>();
                return this.notas;
            }
            set
            {
                this.notas = value;
            }
        }

        //Métodos:
        public double Media() 
        {
            double somaNotas = 0;
            foreach(var nota in this.Notas)
            {
                somaNotas += nota;
            }

            return somaNotas / this.Notas.Count;
        }

        public string Situacao()
        {
            return this.Media() >= 7 ? "Aprovado" : "Reprovado";
        }

        public override string ToString()
        {
            string verAluno = "";
            verAluno += $"Nome: {this.Nome}\n";
            verAluno += $"Matrícula: {this.Matricula}\n";
            verAluno += $"Notas: {string.Join(", ", this.Notas.ToArray())}\n";
            verAluno += $"Média: {this.Media()}\n";
            verAluno += $"Situação: {this.Situacao()}\n";
            verAluno += $"------------------------------------";

            return verAluno;
        }
    }
}
