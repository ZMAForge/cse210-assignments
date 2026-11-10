using System.Runtime.CompilerServices;

abstract class Person
{
    private string _firstname;
    private string _lastname;
    private int _age;
    private double _weight;

    public Person(string firstname, string lastname, int age, double weight)
    {
        _firstname = firstname;
        _lastname = lastname;
        _age = age;
        _weight = weight;
    }

    public virtual string GetPersonInformation()
    {
        return $"{_firstname} {_lastname} is {_age} years old and {_weight} pounds";
    }

    public static void DisplayPersonInformation(Person person)
        {
            if (person is Doctor d)
            {
                Console.WriteLine(d.GetPersonInformation());
            }
            else if (person is Police p)
            {
                Console.WriteLine(p.GetPersonInformation());
            }
            else
            {
            Console.WriteLine(person.GetPersonInformation());
            }
        }
    public abstract double GetSalary();
}