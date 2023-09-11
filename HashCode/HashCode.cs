public class HashCode
{
    public static int v1, v2, v3;
    public static Boolean v4;
    public static string v5, v6;
    public static double v7;


    public static void defineValues ()
    {
        v1 = 27;
        v2 = 239;
        v3 = -12;
        v4 = true;
        v5 = "Zairul";
        v6 = "Mazwan";
        v7 = 2.718;
    }
    public static void genHashCode ()
    {
        defineValues();
        Console.WriteLine("v1 hash code value : "+v1.GetHashCode());
        Console.WriteLine("v2 hash code value : "+v2.GetHashCode());
        Console.WriteLine("v3 hash code value : "+v3.GetHashCode());    
        Console.WriteLine("v4 hash code value : "+v4.GetHashCode()); 
        Console.WriteLine("v5 hash code value : "+v5.GetHashCode()); 
        Console.WriteLine("v6 hash code value : "+v6.GetHashCode()); 
        Console.WriteLine("v7 hash code value : "+v7.GetHashCode()); 
    }
}