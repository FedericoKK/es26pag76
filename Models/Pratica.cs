using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_TPSIT_SantiFederico_es26pag76.Models
{
    class Pratica
    {
        string _nome;
        string _cognome;
        string _codice;
        string _descrizione;
        string _tipo;
        public string Nome { get => _nome; }
        public string Cognome { get => _cognome; }
        public string Codice { get => _codice; }
        public string Descrizione { get => _descrizione; }
        public string Tipo { get => _tipo; }

        public Pratica(string nome, string cognome, string carattere,string descrizione,string tipo)
        {
            _nome = nome;
            _cognome = cognome;
            _codice = carattere;
            _descrizione = descrizione;
            _tipo = tipo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome:\t\t\t{_nome}");
            sb.AppendLine($"Cognome:\t\t{_cognome}");
            sb.AppendLine($"CarattereIdentificativo:\t{_codice}");
            sb.AppendLine($"Descrizione:\t\t\t{_descrizione}");
            sb.AppendLine("\t===============");
            return sb.ToString();
        }
    }
}
