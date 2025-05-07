using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHoteleiro
{
    public class Reserva
    {
        private string descricao;
        private Quarto quarto;
        private string dataAplicacao;
        private decimal valorDiaria;
        private decimal valorTotal;
        private Servicos servicos;

        public Reserva()
        {
            
        }
        public Reserva(string descricao, Quarto quarto, string dataAplicacao, decimal valorDiaria, decimal valorTotal, Servicos servicos)
        {
            this.descricao = descricao;
            this.quarto = quarto;
            this.dataAplicacao = dataAplicacao;
            this.valorDiaria = valorDiaria;
            this.valorTotal = valorTotal;
            this.servicos = servicos;
        }
        
        public string getDescricao() => this.descricao;
        public void setDescricao(string descricao) => this.descricao = descricao;

        public Quarto getQuarto() => this.quarto;
        public void setQuarto(Quarto quarto) => this.quarto = quarto;

        public string getDataAplicacao() => this.dataAplicacao;
        public void setDataAplicacao(string dataAplicacao) => this.dataAplicacao = dataAplicacao;

        public decimal getValorDiaria() => this.valorDiaria;
        public void setValorDiaria(decimal valorDiaria) => this.valorDiaria = valorDiaria;

        public decimal getValorTotal() => this.valorTotal;
        public void setValorTotal(decimal valorTotal) => this.valorTotal = valorTotal;

        public Servicos getServicos() => this.servicos;
        public void setServicos(Servicos servicos) => this.servicos = servicos;
    }

}
