using System;
using System.Security.Cryptography.X509Certificates;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Cidade cidade = new Cidade("Bebedouro", "São Paulo", "SP");
            Endereco endereco = new Endereco("Rua 3", 10, "Centro", "14700-000", cidade);
            Cliente cliente = new Cliente("Vinicius Pimentel", "123456-789", endereco, cidade);
            client.printOutDetails();

            cliente = new Cliente("Vinicius Alonso", "981765-432", "Rua 3", 10, "Centro", "14700-000",
                "Bebedouro", "São Paulo", "SP");
            client.printOutDetails();

            Console.ReadLine();
        }
    }
}