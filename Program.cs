using System;
using AS2021_TPSIT_SantiFederico_es26pag76.Models;

namespace AS2021_TPSIT_SantiFederico_es26pag76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma inserimento pratiche Santi Federico");
            UfficioPratica p = new UfficioPratica();
            p.InserisciPratica("Marco", "Giampaolo", "ASS20", "Squadra serie A","A");
            //ricerca x tipo

            Console.WriteLine("RICERCA X TIPO");
            try { Console.WriteLine(p.RicercaXTipo("B")); }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("--------------------------------------");
            //ricerca x codice
            Console.WriteLine("rICERCA X codice");

            try { Console.WriteLine(p.RicercaXCodice("DDOS2")); }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("--------------------------------------");


            //stampa lista
            Console.WriteLine("Lista completa");
            Console.WriteLine(p.StampaLista());
            Console.WriteLine("--------------------------------------");


            //eliminazione di una pratica
            Console.WriteLine("Lista dopo eliminazione OER20");

            p.EliminazionePratica("OER20");
            //stampa lista dopo eliminazione

            Console.WriteLine(p.StampaLista());
            Console.WriteLine("--------------------------------------");


            //Salvataggio su file
            if (p.SalvataggioPratiche())
                Console.WriteLine("File stampato");
            else
                Console.WriteLine("Non ho stampato");

        }
    }
}
