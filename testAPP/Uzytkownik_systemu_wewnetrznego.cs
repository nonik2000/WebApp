[Serializable]
class Uzytkownik_systemu_wewnetrznego{
    Recenzja recenzja;
    Uzytkownik_platformy_zewnetrznej uzytkownikPlatformyZewnetrznej;
    Filmy filmy;
    Strona strona;
    Statystyka statystyka;
    string imie, nazwisko, email, haslo, nick;
    int id;
    bool autoryzacja;

    public string Imie { get => imie; set => imie = value; }
    public string Nazwisko { get => nazwisko; set => nazwisko = value; }
    public string Email { get => email; set => email = value; }
    public string Haslo { get => haslo; set => haslo = value; }
    public string Nick { get => nick; set => nick = value; }
    public int Id { get => id; set => id = value; }
    public bool Autoryzacja { get => autoryzacja; set => autoryzacja = value; }
}