﻿Random Any = new Random();
string[] GetArray(){
    string[] array = new string[Any.Next(2, 6)];
    Console.WriteLine($"Задайте массив, состоящий из строк и объёмом {array.Length}: ");
    for(int i = 0; i < array.Length; i++){Console.Write($"Элемент {i+1}: "); array[i] = Console.ReadLine()!;}
    return array;
}
string[] RuinArray(string[] array){
int len;
if(array.Length <= 3){len = array.Length;}
else{len = 3;}
string[] newArray = new string[Any.Next(0, len+1)];
for(int i = 0; i < newArray.Length; i++){
    int s = Any.Next(0, array.Length);
    string expect = "";
    bool validate = false;
    for(int j = 0; j < expect.Length; j++){
        if(expect[j] == s){validate = true; break;}
    }
    if(validate == false){
        newArray[i] = array[s];
        expect += s;
    }
}
return newArray;
}
void Write1dArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] array = GetArray();
Console.WriteLine("Получлся вот такой массив: ");
Write1dArray(RuinArray(array));