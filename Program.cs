Console.WriteLine($"Игра BlackJack, с использованием двух колод");

string[] value = new string [] {"2","3","4","5","6","7","8","9","10","Валет","Дама","Король","Туз"};
string[] suit = new string[] {"Черви", "Буби", "Крести", "Пики"};
int x = new Random().Next(0, value.Length);
int y = new Random().Next(0, suit.Length);
string card = value[x] + " " + suit[y];
Console.WriteLine(card);
