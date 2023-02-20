int a = Convert.ToInt32(Console.ReadLine());

if(a < 100)
{
    Console.WriteLine("третьей цифры нет");
}    
else
{
    while(a > 999)
    {
        a = a / 10;
    }

    a = a % 10;  
    Console.WriteLine(a); 
}