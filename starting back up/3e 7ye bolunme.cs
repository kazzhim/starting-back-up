Console.Write("Reqem:");
int n = Convert.ToInt32(Console.ReadLine());
if(n<=0)
{
    Console.WriteLine("duzgunreqem daxil et");
}
else if(n%21!=0)
{
    Console.WriteLine("hem 3e hem 7ye bolunmur");

}
else
{
    Console.WriteLine("hem 3e hem 7ye bolunur");
}