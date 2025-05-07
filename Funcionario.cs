using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHoteleiro
{
    public class Funcionario
    {
        private string nome, codigo, rg, cpf;
        private decimal salario;
        private Endereco endereco;

        public Funcionario()
        {
            
        }

        public Funcionario(string nome, string codigo, string rg, string cpf, decimal salario, Endereco endereco)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.rg = rg;
            this.cpf = cpf;
            this.salario = salario;
            this.endereco = endereco;
        }


        public string getNome() => this.nome;
        public void setNome(string nome) => this.nome = nome;

        public string getCodigo() => this.codigo;
        public void setCodigo(string codigo)=> this.codigo = codigo;

        public string getRg() => this.rg;
        public void setRg(string rg) => this.rg = rg;

        public string getCpf() => this.cpf;
        public void setCpf(string cpf) => this.cpf = cpf;

        public decimal getSalario() => this.salario;
        public void setSalario(decimal salario) => this.salario = salario;

        public Endereco GetEndereco() => this.endereco;
        public void setEndereco(Endereco endereco)=> this.endereco = endereco;

    }
}
