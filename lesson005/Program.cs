Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "бен ладен") // (username == "Бен Ладен") чувствительно к регистру. 
// Добавили ToLower(), для перевода в нижний регистр любого написания
{
    Console.WriteLine("Welcome to NY!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}