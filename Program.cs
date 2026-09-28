// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello, Jerry!");
// Console.ReadKey();

// PrintABC();
// Thread.Sleep(500);
// PrintABC();
// Thread.Sleep(500);
// PrintABC();

// Console.ReadKey();

// void PrintABC()
// {
//     Console.WriteLine("A");
//     Console.WriteLine("B");
//     Console.WriteLine("C");
// }



A();
A();
A();

Console.ReadKey();

void A()
{
    Console.WriteLine("Это функция A");
    B();
    C();
}

void B()
{
    Console.WriteLine("Это функция B");
}

void C()
{
    Console.WriteLine("Это функция C");
}