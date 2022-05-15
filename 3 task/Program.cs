int Lock( int a)
{
    if(a<100)
    {
        Console.WriteLine ("Нет 3  числа");
    }

    else if( a>100){

    
    while (a>1000)
    {
    int b = 10;
    a = a / b;
    
    b=b* 10; 
    }

    Console.WriteLine(a%10);
    }
    return a;
}
int a1=78456445;
Lock(a1);
Console.WriteLine(a1);