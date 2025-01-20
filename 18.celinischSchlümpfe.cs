Console.WriteLine("Willkommen in den celinischen Sümpfen");



while (true)
{
    bool hatKnelt = Frage("Hat Ihr celinischer Freund einen Knelt? (J/N) -->");
    bool loepst = Frage("Loepst er womoeglich? (J/N)                   -->");
    bool manuselt = Frage("Zur Manuseligkeit: manuselt er? (J/N)         -->");
    bool nopelt = Frage("Und ein letztes: nopelt er etwa? (J/N)        -->");


    string stamm;

    if (hatKnelt)
    {
        if (manuselt)
        {
            stamm = "Ein Asi. Gratuliere!";
        }
        else
        {
            if (nopelt)
            {
                stamm = "Ein Cedi. Naja ...";
            }
            else
            {
                stamm = "Um Himmels Willen, ein Drudi!";
            }
        }
    }
    else
    {
        if (nopelt)
        {
            stamm = "Beachtlich: ein Bela!";
        }
        else if (loepst && manuselt)
        {
            stamm = "Ein Cedi. Naja ...";
        }
        else if (loepst && !manuselt)
        {
            stamm = "Um Himmels Willen, ein Drudi!";
        }
        else if (!loepst && !nopelt && manuselt)
        {
            stamm = "Um Himmels Willen, ein Drudi!";
        }
        else if (!loepst && !nopelt && !manuselt)
        {
            stamm = "Ein Cedi. Naja ...";
        }
        else
        {
            stamm = "Ein Gespenst! Das darf nicht sein!";
        }
    }
    Console.WriteLine(stamm);

    Console.WriteLine("<Drücken Sie eine Taste für eine neue Testung (X für Exit)>");
    var key = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (char.ToUpper(key) == 'X')
    {
        break;
    }
}
    
    static bool Frage(string text)
{
    Console.Write(text + " ");
    string antwort = Console.ReadLine()?.Trim().ToLower();
    return antwort == "j";
}

