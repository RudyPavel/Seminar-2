int a = Convert.ToInt32(Console.ReadLine());

if(a < 100 || a > 999)
{
    Console.WriteLine("Не трёхзначное число");
}    
else
{
    a = a / 10;
    a = a % 10; 
    Console.WriteLine(a); 
}