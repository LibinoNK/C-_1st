Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ксюша")
{
    Console.WriteLine("Ура, это же Ксюша!!!");
}
else
{
    Console.Write("Салам, кожанный по имени ");
    Console.WriteLine(username);
}