
// Задание 1
//char again = 'д';
//while (again == 'д')
//{
//    double a;
//    double b;
//    double total;
//    char oper;
//    Console.WriteLine( "Введите первое число: ");
//    a = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine("Введите оператор: ");
//    oper = Convert.ToChar(Console.ReadLine());

//    Console.WriteLine("Введите второе число: ");
//    b = Convert.ToDouble(Console.ReadLine());

//    if (oper == '+')
//    {
//        total = a + b;
//        Console.WriteLine("Сумма" + a + "и" + b + "равна" + total + ".");
//    }
//    else if (oper == '-')
//    {
//        total = a - b;
//        Console.WriteLine("Разность" + a + "и" + b + "равна" + total + ".");
//    }
//    else if (oper == '*')
//    {
//        total = a * b;
//        Console.WriteLine("Умножение" + a + "и" + b + "равно" + total + ".");
//    }

//    else if (oper == '/')
//    {
//        total = a / b;
//        Console.WriteLine("Деление" + a + "и" + b + "равно" + total + ".");
//    }

//    else
//    {
//        Console.WriteLine("Неизвестный оператор");
//    }
//    Console.WriteLine("продолжить работу с калькулятором? (д/н)");
//    again = Convert.ToChar(Console.ReadLine());
//}    


//Задание 2
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string input = Console.ReadLine();

//        int charCount = input.Length;
//        int wordCount = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
//        int sentenceCount = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

//        Console.WriteLine($"Количество символов: {charCount}");
//        Console.WriteLine($"Количество слов: {wordCount}");
//        Console.WriteLine($"Количество предложений: {sentenceCount}");
//    }
//}


//Задание 3
//int[,] mas = new int[10, 10];

//for (int i = 1; i < 10; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        mas[i, j] = i * j;
//        Console.Write("{0}\t", mas[i, j]);
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();


//Задание 4
//int s;
//int F = 1;
//Console.WriteLine("Введите число");
//s = int.Parse(Console.ReadLine());
//for (int c = s; c > 1; c--)
//    F = F * c;
//Console.WriteLine("Факториал =" + F);
//Console.ReadLine();


//Задание 5
//Console.WriteLine("Число n");
//int number = Convert.ToInt32(Console.ReadLine());
//int perv = 1;
//Console.Write("{0}", perv);
//int vtor = 1;
//Console.Write("{0}", vtor);
//int sum = 0;
//while (number >= sum)
//{ 
//    sum = perv + vtor;
//    Console.Write("{0}", sum);
//    perv = vtor;
//    vtor = sum;
//}


//задание 6//
//int a = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//for (int i = 1; i < a; i++)
//{
//    count = 0;
//    for (int j = 1; j < a; j++)
//    { 
//        if (i % j==0) count++;
//    }
//    if (count == 2) Console.WriteLine(i);
//}


//Задание 7//
//int firstval, secret;
//firstval = int.Parse(Console.ReadLine());
//Random random = new Random();
//secret = random.Next(1, 100);

//while (true)
//{
//    if (firstval == secret)
//    {
//        Console.WriteLine("Победа");
//        break;
//    }

//    else if (firstval < secret)
//    {
//        Console.Write("Напиши число больше");
//        firstval = int.Parse(Console.ReadLine());
//    }
//    else if (firstval > secret)
//    {
//        Console.WriteLine("Напиши число меньше" );
//        firstval = int.Parse(Console.ReadLine());
//    }
//}



//Задание 8
