void Write (int a)
{
   Console.WriteLine(a);
   Console.WriteLine( a / 100 * 10 + a%10);   
}
Write(new Random().Next(100,1000));