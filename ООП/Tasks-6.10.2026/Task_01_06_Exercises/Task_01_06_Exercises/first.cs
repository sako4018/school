using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Questions
{   
    string[] answears;

    public void Ask()
    {
        for (int i = 1; i <= 5; i++)
        {
            
            System.Console.WriteLine($"question: {i}");
            answears[i] = Console.ReadLine();

        }
    }
    public void grade()
    {
        int count = 1;
        for (int i = 1; i <= 5; i++)
        {
            if(answears[i] != null)
            {
                count++;
            }
        }
        System.Console.WriteLine($"Your grade is: {count}");
        
    }
}