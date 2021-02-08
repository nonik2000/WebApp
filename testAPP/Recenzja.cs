[Serializable]
class Recenzja{
    string tresc, nick;
    int object_id;
    DateTime czas_data_dodania;

    public string Tresc { get => tresc; set => tresc = value; }
    public string Nick { get => nick; set => nick = value; }
    public int Object_id { get => object_id; set => object_id = value; }
    public DateTime Czas_data_dodania { get => czas_data_dodania; set => czas_data_dodania = value; }
}