[Serializable]
class Strona {
    News news;
    Wydarzenie wydarzenie;
    Gra gra;
    Api api;
    Uzytkownik_platformy_zewnetrznej uzytkownikPlatformyZewnetrznej;;
    string nazwa, url;
    bool aktywna;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public string Url { get => url; set => url = value; }
    public bool Aktywna { get => aktywna; set => aktywna = value; }
}