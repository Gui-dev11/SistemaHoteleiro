using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHoteleiro
{
    public class Cliente
    {
        private string nome, codigo, profissao, rg, cpf;
        private Endereco endereco;

        public Cliente()
        {

        }

        public Cliente(string nome, string codigo, string profissao, string rg, string cpf, Endereco endereco)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.rg = rg;
            this.cpf = cpf;
            this.endereco = endereco;
        }

        public string getNome() => this.nome;
        public void setNome(string nome) => this.nome = nome;

        public string getCodigo() => this.codigo;
        public void setCodigo(string codigo)=> this.codigo = codigo;

        public string getCpf() => this.cpf;
        public void setCpf(string cpf)=> this.cpf = cpf;

        public string getProfissao()=> this.profissao;
        public void setProfissao(string profissao) => this.profissao = profissao;

        public string getRg()=> this.rg;
        public void setRg(string rg) => this.rg = rg;

        public Endereco getEndereco() => this.endereco;
        public void setEndereco(Endereco endereco) => this.endereco = endereco;
    }
}
