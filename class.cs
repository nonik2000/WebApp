class filmy{
    string nazwa, link, opis;
    DateTime data_godzina_dodania;
    bool aktywne;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public string Link { get => link; set => link = value; }
    public string Opis { get => opis; set => opis = value; }
    public DateTime Data_godzina_dodania { get => data_godzina_dodania; set => data_godzina_dodania = value; }
    public bool Aktywne { get => aktywne; set => aktywne = value; }
}

class recenzja{
    string tresc, nick;
    int object_id;
    DateTime czas_data_dodania;

    public string Tresc { get => tresc; set => tresc = value; }
    public string Nick { get => nick; set => nick = value; }
    public int Object_id { get => object_id; set => object_id = value; }
    public DateTime Czas_data_dodania { get => czas_data_dodania; set => czas_data_dodania = value; }
}

class komentarz{
    string tersc, nick;
    int object_id;
    DateTime czas_data_dodania;

    public string Tersc { get => tersc; set => tersc = value; }
    public string Nick { get => nick; set => nick = value; }
    public int Object_id { get => object_id; set => object_id = value; }
    public DateTime Czas_data_dodania { get => czas_data_dodania; set => czas_data_dodania = value; }
}

class gra{
    string nazwa;
    List<string> statystyki = new List<string>();

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public List<string> Statystyki { get => statystyki; set => statystyki = value; }
}

class wydarzenie {
    string wydarzenie, opis;
    DateTime data_godzina;
    bool aktywne;

    public string Wydarzenie { get => wydarzenie; set => wydarzenie = value; }
    public string Opis { get => opis; set => opis = value; }
    public DateTime Data_godzina { get => data_godzina; set => data_godzina = value; }
    public bool Aktywne { get => aktywne; set => aktywne = value; }
}

class news {
    string nazwa, opis, kategoria;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public string Opis { get => opis; set => opis = value; }
    public string Kategoria { get => kategoria; set => kategoria = value; }
}

class statystyka{
    string nazwa, wartosc, tytul_gry;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public string Wartosc { get => wartosc; set => wartosc = value; }
    public string Tytul_gry { get => tytul_gry; set => tytul_gry = value; }
}

class uzytkownik_platformy_zewnetrznej {
    string login, haslo;
    bool autoryzacja;
    int id;

    public string Login { get => login; set => login = value; }
    public string Haslo { get => haslo; set => haslo = value; }
    public bool Autoryzacja { get => autoryzacja; set => autoryzacja = value; }
    public int Id { get => id; set => id = value; }
}

class strona {
    string nazwa, url;
    bool aktywna;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public string Url { get => url; set => url = value; }
    public bool Aktywna { get => aktywna; set => aktywna = value; }
}

class uzytkownik_systemu_wewnetrznego{
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

class api{
    string nazwa, url, api_key;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public string Url { get => url; set => url = value; }
    public string Api_key { get => api_key; set => api_key = value; }
}