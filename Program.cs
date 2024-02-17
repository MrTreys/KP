Random Any = new Random();
string[] GetArray(){
    string[] array = new string[Any.Next(2, 6)];
    Console.WriteLine($"Задайте массив, состоящий из строк и объёмом {array.Length}: ");
    for(int i = 0; i < array.Length; i++){Console.Write($"Элемент {i+1}: "); array[i] = Console.ReadLine()!;}
    return array;
}