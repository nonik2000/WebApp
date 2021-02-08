[Serializable]
class Wydarzenie {
    Strona strona;
    Gra gra;
    Komentarz komentarz;
    string wydarzenie, opis;
    DateTime data_godzina;
    bool aktywne;

    public string Wydarzenie { get => wydarzenie; set => wydarzenie = value; }
    public string Opis { get => opis; set => opis = value; }
    public DateTime Data_godzina { get => data_godzina; set => data_godzina = value; }
    public bool Aktywne { get => aktywne; set => aktywne = value; }
}