// Пользователь вводит с клавиатуры M чисел через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 0, 7, 8, -2, -2 -> 2  
        
Console.Write("Введите числа через запятую: ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше 0: {count}");