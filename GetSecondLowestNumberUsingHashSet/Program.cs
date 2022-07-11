// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadLine();
string inputString = "asd3435tyhtrg";
HashSet<int> hashSetInt = new HashSet<int>();
foreach(char c in inputString)
{
    int num;
    if(Int32.TryParse(c.ToString(),out num))
    {
        hashSetInt.Add(num);
    }    
}
hashSetInt = hashSetInt.OrderByDescending(h => h).ToHashSet<int>();
Console.WriteLine(hashSetInt.ElementAt(1));

