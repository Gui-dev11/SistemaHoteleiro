using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHoteleiro
{
    public class Quarto
    {
        private string descricao, categoria;
        private int numQuarto, qtdCamas;

        public Quarto()
        {
            
        }
        public Quarto(string descricao, int numQuarto, string categoria, int qtdCamas)
        {
            this.descricao = descricao;
            this.numQuarto = numQuarto;
            this.categoria = categoria;
            this.qtdCamas = qtdCamas;
        }

        public string getDescricao() => this.descricao;
        public void setDescricao(string descricao) => this.descricao = descricao;

        public int getNumQuarto() => this.numQuarto;
        public void setNumQuarto(int numQuarto) => this.numQuarto = numQuarto;

        public string getCategoria() => this.categoria;
        public void setCategoria(string categoria) => this.categoria = categoria;

        public int getQtdCamas() => this.qtdCamas;
        public void setQtdCamas(int qtdCamas) => this.qtdCamas = qtdCamas;
    }

}
