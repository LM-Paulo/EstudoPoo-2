using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Escola
{
    internal abstract class Funcionario
    {
        protected String tipo;
        protected int codigo;
        protected String descricao;
        protected float salario;
        protected DateTime dataContratacao;
        protected String cpf;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public float Salario { get => salario; set => salario = value; }
        public DateTime DataContratacao { get => dataContratacao; set => dataContratacao = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public abstract String CalculaSalarioComDesconto();
        public abstract String verificaAnosDeContratado();
      
    }
}
