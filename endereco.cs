using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade
{
    class Endereco : Cidade
    {
        string rua;
        int numero;
        string bairro;
        string cep;

        public void setStreetName(string rua) { this.street = rua; }
        public string getStreetName() { return this.rua; }
        public void setPropertyNumber(int num) { this.number = num; }
        public int getPropertyNumber() { return this.number; }
        public void setNeighborhood(string bairro) { this.bairro = bairro; }
        public string getNeighborhood() { return this.bairro; }
        public void setZipCode(string cep) { this.zipCode = cep; }
        public string getZipCode() { return this.cep;  }
        public void setAddressProperties(Endereco endereco, Cidade cidade)
        {

            this.rua = endereco.rua;
            this.numero = endereco.numero;
            this.bairro = endereco.bairro;
            this.cep = endereco.cep;
            setCityProperties(cidade);

        }

        public Endereco(string rua, int numero, string bairro, string cep, Cidade cidade)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cep = cep;
            
            setCityProperties(cidade);
        }

        public Endereco() {}
    }
}