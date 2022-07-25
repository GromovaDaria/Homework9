// Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
/*int GetNumberOfDigitsInNumber(int N, int counter = 0) {
    if(N > 0)
    {
        counter++;
    }
    
    else
    {
        return counter;
    }

    return GetNumberOfDigitsInNumber(N/10, counter);
}

Console.WriteLine("Write number N and get back the number of digits in the number");
Console.Write("N: ");
var input = Console.ReadLine();


if (Int32.TryParse(input, out int parsedInput)) {
    if (parsedInput < 0) parsedInput = Convert.ToInt32(parsedInput.ToString().Replace("-", ""));
    var numberOfDigits = GetNumberOfDigitsInNumber(parsedInput);
    Console.WriteLine($"There are {numberOfDigits} digits in the number {parsedInput}");
}

else Console.WriteLine("Error: Input not valid");
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSumBetweenMAndN(int M, int N) {
    int sum = 0;

    for (int i = M; i <= N; i++) {
        sum += i;
    }

    return sum;
}

Console.WriteLine("Write numbers N and M and get back the sum of positive numbers between them");
Console.Write("M: ");
var inputM = Console.ReadLine();
Console.Write("N: ");
var inputN = Console.ReadLine();

if (Int32.TryParse(inputM, out int parsedInputM) && Int32.TryParse(inputN, out int parsedInputN)) {
    if (parsedInputM < 0 || parsedInputN < 0) Console.WriteLine("Error: Numbers needs to be positive");
    if (parsedInputM > parsedInputN) Console.WriteLine("Error: M needs to be smaller than N");
    
    var sum = GetSumBetweenMAndN(parsedInputM, parsedInputN);
    Console.WriteLine($"Sum between M and N is {sum}");
}

else Console.WriteLine("Error: Input not valid");