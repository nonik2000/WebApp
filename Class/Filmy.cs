[Serializable]
class Filmy{
    Recenzja recencja;
    Komentarz komentarz;
    Uzytkownik_systemu_wewnetrznego uzytkownik_systemu_wewnetrznego;
    string nazwa, link, opis;
    DateTime data_godzina_dodania;
    bool aktywne;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public string Link { get => link; set => link = value; }
    public string Opis { get => opis; set => opis = value; }
    public DateTime Data_godzina_dodania { get => data_godzina_dodania; set => data_godzina_dodania = value; }
    public bool Aktywne { get => aktywne; set => aktywne = value; }
}