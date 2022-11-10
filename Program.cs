// See https://aka.ms/new-console-template for more information




try
{
    Console.WriteLine("inserisci nome evento");
    string nomeEvento = Console.ReadLine();

    Console.WriteLine("inserisci data evento (gg/mm/yyyy)");
    DateTime dataEvento = DateTime.Parse((Console.ReadLine()));

    Console.WriteLine("inserisci numero posti max evento");
    int postiMaxEvento = Convert.ToInt32(Console.ReadLine());

    Evento evento1 = new Evento(nomeEvento, dataEvento, postiMaxEvento, 0);

    Console.WriteLine("inserisci numero posti che vuoi prenotare:");
    int inputPrenotaPosti = Convert.ToInt32(Console.ReadLine());

    evento1.prenotaPosti(inputPrenotaPosti);

    Console.WriteLine("nome evento: {0}, data evento {1}, numero posti max: {2}, posti prenotati: {3}", evento1.Titolo, evento1.Data, evento1.PostiMax, evento1.PostiPrenotati);

    Console.WriteLine("vuoi disdire alcune prenotazioni? [si/no]");
    string conferma = Console.ReadLine();

    if (conferma == "si")
    {
        Console.WriteLine("quanti posti vuoi disdire?");
        int inputDisdire = Convert.ToInt32(Console.ReadLine());
        evento1.disdiciPosti(inputDisdire);
        Console.WriteLine("Posti prenotati: {0}", evento1.PostiPrenotati);
        Console.WriteLine("Posti disponibili: {0}", evento1.postiDisponibili());
    }






    Console.WriteLine("Inserisci il nome del tuo programma di eventi:");
    string nomeProgramma = Console.ReadLine();
    Console.WriteLine("inserisci il numero di eventi da inserire:");
    int numeroEventi = Convert.ToInt32(Console.ReadLine());
    ProgrammaEventi programma = new ProgrammaEventi(nomeProgramma);
    for (int i = 1; i <= numeroEventi; i++)
    {
        CreaEvento(i);
    }
        
}
catch (GestoreEventiExpection e)
{
    Console.WriteLine(e.Message);
}

void CreaEvento(int numero)
{
    bool successo = false;
    do
    {
        Console.WriteLine("Inserisci il nome del " + numero + "° evento:");
        string nome = Console.ReadLine();
        Console.WriteLine("inserisci data evento (gg/mm/yyyy)");
        DateTime data = DateTime.Parse((Console.ReadLine()));

        Console.WriteLine("inserisci numero posti max evento");
        int postiMaxEvento = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("inserisci numero posti che vuoi prenotare:");
        int inputPrenotaPosti = Convert.ToInt32(Console.ReadLine());
        try
        {
            Evento evento = new Evento(nome, data, postiMaxEvento, inputPrenotaPosti);
            programma.AggiungiEvento(evento);
            successo = true;
        }
        catch (GestoreEventiException e)
        {
            Console.WriteLine(e.Message);
        }
    } while (!successo);
}








