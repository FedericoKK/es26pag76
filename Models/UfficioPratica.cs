using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AS2021_TPSIT_SantiFederico_es26pag76.Models
{
    class UfficioPratica
    {
        List<Pratica> _pratiche = new List<Pratica>();

        public UfficioPratica()
        {
            //creazione lista
            _pratiche = new List<Pratica>
            {
                new Pratica("Santi","Federico","SES10","Soldi Gratis","A"),
                new Pratica("Bronz","Modz","DDOS2","Postepay Gratis","A"),
                new Pratica("Pavarotti","Federico","OER20","Una voce bella","B"),
                new Pratica("Nando", "Angela","WCC01","Displuvi","C")
            };
        }
        //creazione lista
        public void InserisciPratica(string nome, string cognome, string codice,string descrizione,string tipo) => _pratiche.Add(new Pratica(nome, cognome,codice,descrizione,tipo));
        //ricerca x tipo
        public Pratica RicercaXTipo(string tipo)
                    {
                        foreach(Pratica p in _pratiche)
                            if (p.Tipo == tipo)
                                return p;

                        throw new Exception($"La pratica :{tipo} non è stata trovato!");
                    }
        //ricerca x codice
        public Pratica RicercaXCodice(string codice)
                {
                    foreach (Pratica p in _pratiche)
                        if (p.Codice == codice)
                            return p;

                    throw new Exception($"La pratica:{codice} non è stata trovata!");
                }
        //eliminazione pratica
        public bool EliminazionePratica(string codice)
                {
                    for(int i = 0;i<_pratiche.Count;i++)
                        if (_pratiche[i].Codice == codice)
                        {
                            _pratiche.RemoveAt(i);
                            return true;
                        }
                    
                    return false;
                }
        public bool SalvataggioPratiche()
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Orario {DateTime.Now.ToString()}");
                        //aggiunge ogni pratica della list alla stringa
                            foreach (Pratica p in _pratiche)
                                sb.AppendLine(p.ToString());

                        //scrive all'interno del file la stringa creata
                        File.AppendAllText("ListaPratiche.txt", sb.ToString());

                            return true;
                    }
        public string StampaLista()
        {
                StringBuilder sb = new StringBuilder();

                    //aggiunge ogni pratica della list alla stringa
                    foreach (Pratica p in _pratiche)
                     sb.AppendLine(p.ToString());
                        return sb.ToString();
        }

    }
}
