using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHoteleiro
{
    public class Servicos
    {
        private string descricao, categoria;
        private decimal valor;
        private bool ativo;

        public Servicos()
        {
            
        }
        public Servicos(string descricao, decimal valor, string categoria, bool ativo)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.categoria = categoria;
            this.ativo = ativo;
        }

        public string getDescricao() => this.descricao;
        public void setDescricao(string descricao) => this.descricao = descricao;

        public decimal getValor() => this.valor;
        public void setValor(decimal valor) => this.valor = valor;

        public string getCategoria() => this.categoria;
        public void setCategoria(string categoria) => this.categoria = categoria;

        public bool getAtivo() => this.ativo;
        public void setAtivo(bool ativo) => this.ativo = ativo;
    }

}
