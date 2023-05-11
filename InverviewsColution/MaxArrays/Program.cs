var numbers = new int[] { 20, -50, -8, 25, 100, 35 };

var sumNumbers1 = GetSumValuesWithoutMaxUsingEnumerable(numbers);
Console.WriteLine($"The sum of all positives values without max value is: {sumNumbers1} using Enumerable");

var sumNumbers2 = GetSumValuesWithoutMaxUsingIteration(numbers);
Console.WriteLine($"The sum of all positives values without max value is: {sumNumbers2} using Iterations");


int GetSumValuesWithoutMaxUsingEnumerable(int[] numbers) 
{
    //First Approach using Enumerable.Max and Enumerable Sum
    var maxNumber = numbers.Max();
    Console.WriteLine($"Ther max item value is: {maxNumber}");

    var sumNumbers = numbers.Where(x => x > 0 && x != maxNumber).Sum();    
    return sumNumbers;
}

int GetSumValuesWithoutMaxUsingIteration(int[] numbers)
{
    var maxNumber = 0;
    var sumNumbers = 0;
    foreach (int number in numbers) 
    {
        if (number > 0) 
        {
            if(number > maxNumber) 
            {
                maxNumber = number;
            }
            sumNumbers += number;
        }
    }
    sumNumbers -= maxNumber;
    Console.WriteLine($"Ther max item value is: {maxNumber}");
    return sumNumbers;
}