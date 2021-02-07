using System;
using MySql.Data.MySqlClient;

namespace testAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 01:");
            test01();
            Console.WriteLine("-----------------");
            Console.WriteLine("Test 02:");
            test02();
        }
        public static void test01()
        {
            string t1_db_user = "admin", t1_db_passwd = "haslo";
            Uzytkownik_systemu_wewnetrznego user_wew = new Uzytkownik_systemu_wewnetrznego();
            user_wew.Nick = "admin";
            user_wew.Haslo = "haslo";
           
            if (t1_db_user == user_wew.Nick && t1_db_passwd == user_wew.Haslo)
            {
                user_wew.Autoryzacja = true;
                Console.WriteLine("Użytkownik zalogowany");
                Console.WriteLine("Test zakończony powodzeniem");
                strona_powitalna();
            }
            else
            {
                user_wew.Autoryzacja = false;
                Console.WriteLine("Użytkownik niezalogowany");
                Console.WriteLine("Test zakończony niepowodzeniem");
            }
        }
        public static void test02()
        {
            string t2_db_user = "admin", t2_db_passwd = "haslo";
            Uzytkownik_systemu_wewnetrznego user_wew = new Uzytkownik_systemu_wewnetrznego();
            user_wew.Nick = "admin";
            user_wew.Haslo = "haslo1234";

            if (t2_db_user == user_wew.Nick && t2_db_passwd == user_wew.Haslo)
            {
                user_wew.Autoryzacja = true;
                Console.WriteLine("Użytkownik zalogowany");
                Console.WriteLine("Test zakończony nipowodzeniem");
                strona_powitalna();
            }
            else
            {
                user_wew.Autoryzacja = false;
                Console.WriteLine("Użytkownik niezalogowany");
                Console.WriteLine("Test zakończony powodzeniem");
            }
        }
        public static void strona_powitalna()
        {

        } 
    }
}
