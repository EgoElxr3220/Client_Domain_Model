using CompanyManagement.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Client client1 = new Client("SnowTech Solutions", "info@snowtech.com");
        string client1Summary = client1.GetSummary();
        Console.WriteLine(client1Summary);

        Client client2 = new Client("Ego's Elixirs", "info@egoselixirs.com");
        client2.Deactivate();
        string client2Summary = client2.GetSummary();
        Console.WriteLine(client2Summary);

        
    }
}