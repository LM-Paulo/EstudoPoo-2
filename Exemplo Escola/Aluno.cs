using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Escola
{
    internal class Aluno 
    {
        private int id;
        private String nome;
        private String dataNasc;
        private String cpf;
        private String status;
        private double nota1, nota2, nota3;
        private Professor professor;

        public Aluno(int id, string nome, string dataNasc, string cpf, string status,Professor professorAluno)
        {
            this.id = id;
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.cpf = cpf;
            this.status = status;
            this.professor = professorAluno;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Status { get => status; set => status = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        internal Professor Professor { get => professor; set => professor = value; }

        public String cadastroDeNotas(double Nota1,double Nota2, double Nota3)
        {
            this.nota1 = Nota1;
            this.nota2 = Nota2;
            this.nota3 = Nota3;
            
            return "Notas cadastradas com Sucesso";

        }
        public void consultaDeAprovacao()
        {
            double NotaTotal = (nota1 + nota2 + nota3) / 3;

            

           switch (NotaTotal)
            {
                 
                case > 60:

                    Console.WriteLine("Olá " + nome + ", Você foi aprovado!");
                 

                    break;

                case > 40:

                    Console.WriteLine("Olá " + nome + ", Você está em Recuperação!");

                    break;

                case < 40:

                    Console.WriteLine("Olá " + nome + ", Você foi Reprovado!");

                    break;      
            }


           
        }



    }
}
