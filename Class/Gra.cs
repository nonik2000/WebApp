[Serializable]
class Gra{
    Statystyka statystyka;
    Strona strona;
    Wydarzenie wydarzenie;
    Komentarz komentarz;
    Recenzja recenzja;
    string nazwa;
    List<Statystyka> statystyka_lista = new List<Statystyka>();
    public string Nazwa { get => nazwa; set => nazwa = value; }
    public List<statystyka> Statystyka_lista { get => statystyka; set => statystyka = value; }
}