Console.Write("Введите имя ");
string name = Console.ReadLine();
string rightname = "андрей";
if (name.ToLower() == rightname){
    Console.Write("Приветствую, ");
    Console.WriteLine(name);
}
else{
    Console.Write("Привет ");
    Console.WriteLine(name);
}