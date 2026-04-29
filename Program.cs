int temp = 15; 

switch (temp)
{ 
    case <-25:
    {
        Console.WriteLine("Freezing!");
        break;
    }
    case <-10:
        {
            Console.WriteLine("Cold");
            break;
        }
    case <1:
        {
            Console.WriteLine("Chill");
            break;
        }    
    case <10:
        {
            Console.WriteLine("Warm");
            break;
        }    
    case <25:
        {
            Console.WriteLine("Hot!");
            break;
        }    
}