using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHoteleiro
{
    public class Endereco
    {
        private string logradouro, bairro, cidade, cep, estado, numero, complemento;

        public Endereco()
        {
            
        }

        public Endereco(string logradouro, string bairro, string cidade, string cep, string estado, string numero, string complemento)
        {
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.cidade = cidade;
            this.cep = cep;
            this.estado = estado;
            this.numero = numero;
            this.complemento = complemento;
        }

        public string getLogradouro() => this.logradouro;
        public void setLogradouro(string logradouro) => this.logradouro = logradouro;

        public string getBairro() => this.bairro;
        public void setBairro(string bairro) => this.bairro = bairro;

        public string getCidade() => this.cidade;
        public void setCidade(string cidade) => this.cidade = cidade;

        public string getCep() => this.cep;
        public void setCep(string cep) => this.cep = cep;

        public string getEstado() => this.estado;
        public void setEstado(string estado) => this.estado = estado;

        public string getNumero() => this.numero;
        public void setNumero(string numero) => this.numero = numero;

        public string getComplemento() => this.complemento;
        public void setComplemento(string complemento) => this.complemento = complemento;
    }
}
