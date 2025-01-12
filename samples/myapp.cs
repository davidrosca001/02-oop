namespace MyApplication;
using bankaccount;
using Person;
using Address;
class Program
{
    static void Main(string[] args)
    {
        bankaccount person1 = new bankaccount();
        person1.BankBalance = 32;

        Console.WriteLine(person1.BankBalance);
        person1.BankingFirstName = "David";
        person1.BankingSecondName = "Rosca";

        Console.WriteLine(person1.AccountOwner());
        Console.WriteLine(person1.CheckIfCovered());

        person1.SetPayOut = 34;
        person1.PayOutExecution();
        Console.WriteLine(person1.CheckIfCovered());


        bankaccount person2 = new bankaccount();
        person2.BankingFirstName = "David";
        person2.BankingSecondName = "Negrau";
        Console.WriteLine(person2.AccountOwner());

        person2.BankBalance = 92;
        Console.WriteLine(person2.BankBalance);
        person2.SetPayIn = 44;
        person2.PayInExecution();
        Console.WriteLine(person2.BankBalance);

        bankaccount person3 = new bankaccount();
        person3.BankingFirstName = "David";
        person3.BankingSecondName = "Nicolae";
        Console.WriteLine(person3.AccountOwner());

        person3.BankBalance = 1000;
        person3.SetPayIn = 50;
        person3.PayInExecution();
        Console.WriteLine(person3.BankBalance);
        person3.SetPayOut = 400;
        person3.PayOutExecution();
        Console.WriteLine(person3.CheckIfCovered());

        Address person4 = new Address("Gleisdorfweg", 42, 8200, "Gleisdorf");
        Console.WriteLine(person4.Streetname);
        Console.WriteLine(person4.FullAdress());

        bankaccount person5 = new bankaccount();
        person5.BankingFirstName = "Max";
        person5.BankingSecondName = "Gether";
        person5.OwnerStreetName = "Weizerweg";
        person5.OwnerHouseNumber = 77;
        person5.OwnerPLZ = 8160;
        person5.OwnerCityName = "Weiz";

        Console.WriteLine(person5.FullOwnerAddress());


        List<bankaccount>
List<bankaccount> listOfaccounts = new List<bankaccount>();
        listOfaccounts.Add(person1);
        listOfaccounts.Add(person2);
        listOfaccounts.Add(person3);

        for (int i = 0; i < listOfaccounts.Count; i++)
        {
            Console.WriteLine(listOfaccounts[i].CheckIfCovered());
        }
    }
}