using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine($"Salary: {person.GetSalary()}");
        Console.WriteLine(person.GetPersonInformation());
    }
    public static void Main()
    {

        // Person myPerson = new Person("John", "Revalator", 50, 180.0);
        // Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Paine", 45, 279, "Knife");
        // Console.WriteLine(myDoctor.GetPersonInformation());
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        Police myPolice = new Police("Gary", "Goodman", 61, 181, "Guns");
        // Console.WriteLine(myPolice.GetPoliceInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }
}