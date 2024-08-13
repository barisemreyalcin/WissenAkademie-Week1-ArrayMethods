// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region Array Methods

//string[] cities = { "Ankara", "İstanbul", "Bursa", "Erzurum", "Çanakkale", "Bilecik", "İzmir", "Kars" };

//Array.Sort(cities);

//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}

//Console.WriteLine(new String('*', 20));

//Array.Reverse(cities);

//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}

//Console.WriteLine(new String('*', 20));

//Array.Resize(ref cities, 5);
//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}

//Array.Resize(ref cities, cities.Length + 1);
//cities[cities.Length - 1] = "Hatay";
//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}

//string[] cities = { "Ankara", "İstanbul", "Bursa", "Erzurum", "Ankara", "Çanakkale", "Bilecik", "İzmir", "Ankara", "Kars" };
//int firstIndex = Array.IndexOf(cities, "Ankara");
//int lastIndex = Array.LastIndexOf(cities, "Ankara");

//string[] cities = { "Ankara", "İstanbul", "Bursa", "Erzurum", "Ankara", "Çanakkale", "Bilecik", "İzmir", "Ankara", "Kars" };
////Array.Clear(cities);

//string[] newCities = (string[])cities.Clone(); // Boxing - Unboxing: Önce boxing yaparak objeye çevirip sonra unboxing yaparak string dizisine dönüştürüyoruz.

////Console.WriteLine(firstIndex);
////Console.WriteLine(lastIndex);
//Console.ReadLine();

#endregion

#region TASK

string[] cities = { "Ankara", "İzmir", "İstanbul", "Bursa", "İzmir", "Erzurum", "Ankara", "Çanakkale", "İstanbul", "Bursa", "Bilecik", "İzmir", "Bursa", "Ankara", "Kars", "İstanbul" };
// Hangi dizinin elemanı kaç adet tekrar etmiş? & Bütün elemanlar bir kere olacak şekilde yapılandıran program.

string[] uniqueCities = new string[0];

foreach (string city in cities)
{
    int counter = 0;

    if (Array.IndexOf(uniqueCities, city) != -1)
        continue;
    else
    {
        for (int i = 0; i < cities.Length; i++)
        {
            if (cities[i] == city)
                counter++;
        }
        Array.Resize(ref uniqueCities, uniqueCities.Length + 1);
        uniqueCities[uniqueCities.Length - 1] = city;
        Console.WriteLine($"{uniqueCities[uniqueCities.Length - 1]}: {counter}");
    }
}

Console.WriteLine(new String('/', 25));

for (int i = 0; i < uniqueCities.Length; i++)
{
    Console.WriteLine($"Unique city {i + 1}: {uniqueCities[i]}");
}

#endregion

//Directory.CreateDirectory("C:\\Deneme");
//Directory.CreateDirectory(@"C:\Deneme");
//Random random = new Random();
//int randomInt = random.Next(100);
//int randomInt2 = random.Next(100, 200);
//Console.WriteLine(randomInt);
//Console.WriteLine(randomInt2);
//Console.ReadLine();
