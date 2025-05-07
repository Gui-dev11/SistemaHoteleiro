using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHoteleiro
{
    public class Hotel
    {
        private string nomeCompleto, nomeEmpresa, dataFundacao, emailCorporativo;
        private Endereco endereco;

        public Hotel()
        {

        }

        public Hotel(string nomeCompleto, string nomeEmpresa, string dataFundacao, string emailCorporativo, Endereco endereco)
        {
            this.nomeCompleto = nomeCompleto;
            this.nomeEmpresa = nomeEmpresa;
            this.dataFundacao = dataFundacao;
            this.emailCorporativo = emailCorporativo;
            this.endereco = endereco;
        }


        public string getNomeCompleto() => this.nomeCompleto;
        public void setNomeCompleto(string nomeCompleto) => this.nomeCompleto = nomeCompleto;

        public string getNomeEmpresa() => this.nomeEmpresa;
        public void setNomeEmpresa(string nomeEmpresa) => this.nomeEmpresa = nomeEmpresa;

        public string getDataFundacao() => this.dataFundacao;
        public void setDataFundacao(string dataFundacao) => this.dataFundacao = dataFundacao;

        public string getEmailCorporativo() => this.emailCorporativo;
        public void setEmailCorporativo(string emailCorporativo) => this.emailCorporativo = emailCorporativo;

        public Endereco GetEndereco() => this.endereco;
        public void setEndereco(Endereco endereco) => this.endereco = endereco;
    }
}
