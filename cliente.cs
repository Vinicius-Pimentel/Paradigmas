using System;
using System.Collections.Generic;

namespace Atividade

{
    class Cliente : Endereco
    {
        string nome;
        string cpf;

        public void setClientName(string nome) { this.nome = nome; }
        public string getClientName() { return this.nome; }
        
        public void setClientCpf(string cpf) { this.cpf = cpf; }
        public string getClientCpf() { return this.cpf; }      

        public void printOutDetails()

        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Cidade: " + getCityName());
            Console.WriteLine("Estado: " + getCityState());
            Console.WriteLine("Bairro: " + getNeighborhood());
            Console.WriteLine("CEP: " + getZipCode());
            Console.WriteLine("Rua: " + getStreetName());
            Console.WriteLine("Número: " + getPropertyNumber());
            Console.WriteLine("Sigla: "  + getStateAbreviation());
        }

        public Client(string nome, string cpf, Address endereco, City cidade)
        {
            this.nome = nome;
            this.cpf = cpf;

            setAddressProperties(endereco, cidade);
        }

        public Client(string nome, string cpf, string rua, int numero, string bairro, string cep, string cidade, string estado, string estadoAbv)
        {
            this.name = nome;
            this.cpf = cpf;

            setStreetName(rua);
            setPropertyNumber(numero);
            setNeighborhood(bairro);
            setZipCode(cep);
            setCityName(cidade);
            setCityState(estadp);
            setStateAbreviation(estadoAbv);
        }
    }
}
