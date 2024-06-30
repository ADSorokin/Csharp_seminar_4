using System;

class Answer
{

 static void Main(){

Console.WriteLine("введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] array = FulfillRandomArray(size);
        PrintArray(array);
        int count = Count(array);
        Console.WriteLine($"Количество четных чисел в массиве: {count}");


    }
static int Count(int[] array){
    int cnt = 0;
    foreach (int val in array)
        {
            if (val % 2 == 0)
            {cnt++;}
        }
        return cnt;
    }

static int[] FulfillRandomArray(int size){
    Random random = new Random();
    int[] array = new int[size];
    for(int i =0; i<size; i++){
        array[i]=random.Next(100,1000);
    }

    return array;

}

static void PrintArray(int[] array){
    foreach(int iter in array)
    Console.Write($"{iter} ");
}


}
