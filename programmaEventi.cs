// See https://aka.ms/new-console-template for more information




public class ProgrammaEventi
{
    public string _titolo;
    List<Evento> eventi;
    public string Titolo
    {
        get
        {
            return _titolo;
        }

        set
        {
            if (value == null || value == "")
            {
                throw new GestoreEventiExpection("Il formato del titolo non è valido");
            }
            _titolo = value;
        }
    }


    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        eventi = new List<Evento>();
    }

    //aggiunge evento alla lista
    public void AggiungiEvento(Evento evento)
    {
        eventi.Add(evento);
    }

    //cerca evento per data
    public List<Evento> cercaEventi(DateTime data)
    {
        List<Evento> eventoData = new List<Evento>();
        foreach (Evento evento in eventi)
        {
            if(evento.Data == data)
            {
                eventoData.Add(evento);
            }
        }
        return eventi;
    }

    public static string StampaListaEventi(List<Evento> eventi)
    {
        if (eventi == null)
            throw new GestoreEventiExpection("Non sono stati trovati eventi");
        string stampa = "";
        foreach (Evento evento in eventi)
        {
            if (stampa == "")
                stampa = evento.ToString() + "\n";
            else
                stampa = stampa + evento.ToString() + "\n";
        }
        return stampa;
    }

    //ritorna il numero di eventi
    public int numeroEventi()
    {
        return eventi.Count;
    }

    //svuota la lista degli eventi
    public void eliminaEventi()
    {
        eventi.Clear();
    }

    public override string ToString()
    {
        string stampa = Titolo + "\n";
        foreach (Evento evento in eventi)
        {
            stampa = stampa + "\t" + evento.ToString() + "\n";
        }
        return stampa;
    }

}









