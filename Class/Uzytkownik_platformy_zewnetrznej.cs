class Uzytkownik_platformy_zewnetrznej {
    string login, haslo;
    bool autoryzacja;
    int id;

    public string Login { get => login; set => login = value; }
    public string Haslo { get => haslo; set => haslo = value; }
    public bool Autoryzacja { get => autoryzacja; set => autoryzacja = value; }
    public int Id { get => id; set => id = value; }
}