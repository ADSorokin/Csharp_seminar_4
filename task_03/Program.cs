//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
using System;

class Answer
{

 static void Main(){

Console.WriteLine("введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] array = FulfillRandomArray(size);
        PrintArray(array);
        int[] reversArray= ToReverseArray(array,size);
        Console.WriteLine("\n Реверсивный массив: ");
        PrintArray(reversArray);
           
    }
static int[] ToReverseArray(int[] array,int size){
    int[] temp = new int[size];
    for(int i =0; i<size; i++)
    {
        temp[size-1-i]=array[i];
    }

return temp;
}

static int[] FulfillRandomArray(int size){
    Random random = new Random();
    int[] array = new int[size];
    for(int i =0; i<size; i++){
        array[i]=random.Next(1,1000);
    }

    return array;

}

static void PrintArray(int[] array){
    foreach(int iter in array)
    Console.Write($"{iter} ");
}


}
