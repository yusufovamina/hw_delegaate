#region task1
//MessageDelegate displayMessageDelegate;

//displayMessageDelegate = UpperMessage;
//displayMessageDelegate("upper case for this message");

//displayMessageDelegate = CountLetters;
//displayMessageDelegate("Count letters");

//displayMessageDelegate = displayInformation;
//displayMessageDelegate("Message for displaying information");

//displayMessageDelegate = Greeting;
//displayMessageDelegate("Amina");



//void UpperMessage(string message)
//{
//    Console.WriteLine(message.ToUpper());
//}
//void CountLetters(string message)
//{
//    Console.WriteLine($"Message '{message}' contains {message.Length} letters");
//}
//void displayInformation(string message)
//{
//    Console.WriteLine(message);
//}
//void Greeting(string name)
//{
//    Console.WriteLine($"Welcome, {name}");
//}

//delegate void MessageDelegate(string message);

#endregion

#region task2
//первый вариант
CalculatorDelegate sum = Sum;
CalculatorDelegate subst = Subtract;
CalculatorDelegate multiply = Multiply;


Console.WriteLine($"Sum: {sum(2.5,7.7)}");
Console.WriteLine($"Substract: {subst(8.5,2)}");
Console.WriteLine($"Multiply: {multiply(2, 5.5)}");

double Sum(double left, double right)
{
    return left + right;
}

double Subtract(double left, double right)
{
    return left - right;
}



double Multiply(double left, double right)
{
    return left * right;

}

public delegate double CalculatorDelegate(double left, double right);
//второй вариант

//CalculatorDelegate calculators = Sum;

//calculators += Subtract;
//calculators += Multiply;

//calculators(7,3.5);

//void Sum(double left, double right)
//{
//    Console.WriteLine(left + right);
//}

//void Subtract(double left, double right)
//{
//    Console.WriteLine(left - right);
//}



//void Multiply(double left, double right)
//{
//    Console.WriteLine(left * right);

//}
//public delegate void CalculatorDelegate(double left, double right);
#endregion


#region task3
//EvenOddDelegate checkEven = IsEven;
//EvenOddDelegate checkOdd = IsOdd;
//int numb = 23;
//bool isEven = checkEven(numb);
//bool isOdd = checkOdd(numb);
//Console.WriteLine($"Number {numb} is odd: {isOdd}");
//Console.WriteLine($"Number {numb} is even: {isEven}");

//первый вариант

//bool IsEven(int number)
//{
//    return number % 2 == 0;
//}

// bool IsOdd(int number)
//{
//    return number % 2 != 0;
//}

//второй вариант
//bool IsEven(int number)
//{
//    return number % 2 == 0;
//}

//bool IsOdd(int number)
//{
//    return !IsEven(number);
//}

//delegate bool EvenOddDelegate(int number);
#endregion