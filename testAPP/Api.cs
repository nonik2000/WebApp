[Serializable]
class Api{
    string nazwa, url, api_key;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public string Url { get => url; set => url = value; }
    public string Api_key { get => api_key; set => api_key = value; }
}