using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade

{
    class Cidade
    {
        string nome;
        string estado;
        string abv;

        public void setCityName(string nome) { this.nome = nome; }

        public string getCityName() { return this.nome; }

        public void setCityState(string nome) { this.estado = nome; }

        public string getCityState() { return this.estado; }

        public void setStateAbreviation(string a) { this.abv = a; }

        public string getStateAbreviation() { return this.abv; }

        public void setCityProperties(Cidade cidade)

        {
            this.nome = cidade.getCityName();
            this.estado = cidade.getCityState();
            this.abv = cidade.getStateAbreviation();
        }

        public Cidade(string nome, string estado, string estadoAbv)
        
        {
            this.nome = nome;
            this.estado = estado;
            this.abv = estadoAbv;
        }

        public Cidade() { }
    }
}