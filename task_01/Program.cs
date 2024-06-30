using System;

class Answer
{

 static void Main(){

Console.WriteLine("Введите свое целое число или q для выхода: ");

while(true){
 string? str = Console.ReadLine();
if(str=="q"){
    Console.WriteLine("пока пока! ");
    break;   
};

int digit = Convert.ToInt32(str);
if(SumOfDigits(digit)%2==0){
    Console.WriteLine($"Сумма цифр ({SumOfDigits(digit)}) в  числе {digit} - четная!");
    break;
    }
Console.Write("Пробуй еще: ");
continue;


    }

}

    static int SumOfDigits(int val)
    {
        int sum = 0;
        while (val != 0)
        {
            sum += Math.Abs(val % 10);
            val /= 10;
        }

        return sum;
    }
}