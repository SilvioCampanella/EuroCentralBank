using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Esercizio_Paesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] paesieurozona = { "Austria", "Belgio", "Cipro", "Estonia", "Finlandia", "Francia", "Germania", "Grecia", "Irlanda", "Italia", "Lettonia", "Lituania", "Lussemburgo", "Malta", "PaesiBassi", "Portogallo", "Slovacchia", "Slovenia", "Spagna" };
            string[] paesiunioneeuropea = { "Austria", "Belgio", "Bulgaria", "Cipro", "Croazia", "Danimarca", "Estonia", "Finlandia", "Francia", "Germania", "Grecia", "Irlanda", "Italia", "Lettonia", "Lituania", "Lussemburgo", "Malta", "Paesi Bassi", "Polonia", "Portogallo", "Repubblica Ceca", "Romania", "Slovacchia", "Slovenia", "Spagna", "Svezia", "Ungheria" };
            string[] paesipenadimorte = { "Afghanistan", "Antigua", "Barbuda", "Arabia Saudita", "Bahamas", "Bahrein", "Bangladesh", "Barbados", "Belize", "Bielorussia", "Botswana", "Cina", "Comore", "Corea del Nord", "Cuba", "Dominica", "Egitto", "Emirati Arabi Uniti", "Etiopia", "Gambia", "Giamaica", "Giappone", "Giordania", "Guyana", "India", "Indonesia", "Iran", "Iraq", "Kuwait", "Lesotho", "Libano", "Libia", "Malesia", "Nigeria", "Oman", "Pakistan", "Palestina", "Qatar", "Repubblica Democratica del Congo", "Saint Kitts", "Nevis", "Saint Lucia", "Saint Vincent", "Grenadine", "Singapore", "Siria", "Somalia", "Stati Uniti d'America", "Sudan", "Sudan del Sud", "Taiwan", "Thailandia", "Trinidad", "Tobago", "Uganda", "Vietnam", "Yemen", "Zimbabwe" };
            Console.WriteLine("I paesi dell'EuroZona sono:");
            foreach (string paesiez in paesieurozona)
            {
                Console.WriteLine(paesiez);
            }
            
            Console.WriteLine("\nI paesi dell'Unione Europea sono:");
            foreach (string paesiue in paesiunioneeuropea)
            {
                Console.WriteLine(paesiue);
            }

            Console.WriteLine("\nI paesi con la pena  di morte in Europa sono: Bielorussia");

            Console.WriteLine("\nI paesi con la pena di morte sono:");
            foreach (string paesipm in paesipenadimorte)
            {
                Console.WriteLine(paesipm);
            }
        }
    }
}

    

