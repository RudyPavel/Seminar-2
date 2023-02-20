int a = Convert.ToInt32(Console.ReadLine()); //день недели 1 2 3 4 5 6 7

if(a < 1 || a > 7)
{
    Console.WriteLine("Не день недели..."); 
}    
else
{   
   if(a == 6 || a == 7)
    Console.WriteLine("да");
   else
    Console.WriteLine ("нет");
}