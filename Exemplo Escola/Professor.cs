using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Escola
{
    internal class Professor : Funcionario
    {
       
        private String nome;
        private String materia;
        
        public Professor(string Nome1, string materia1,float Salario1,DateTime dateTime)
        {
            this.tipo = "professor";
            this.nome = Nome1;
            this.materia = materia1;
            this.salario = Salario1;
            this.dataContratacao = dateTime;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Materia { get => materia; set => materia = value; }

        public override String CalculaSalarioComDesconto()
        {
            return this.nome + ", O seu salário liquido é: " + (salario - (salario * 6 / 100));

        }


        public override String verificaAnosDeContratado()
        {
            DateTime date_1 = dataContratacao;
            DateTime date_2 = DateTime.Now;

            double data = ((date_2 - date_1).Days) / 365;

            return this.nome + ", você está na empresa há: " + data + " Anos";

        }

        public override string? ToString()
        { 
            return "O seu nome e: " + this.nome;
        }
    }
}
