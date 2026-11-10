using System.Security.Cryptography;

class Doctor: Person
{
    private string _tools;
    public Doctor(string firstname, string lastname, int age, double weight, string tools)
    :base(firstname, lastname, age, weight)
    {
        _tools = tools;
    }

    public override string GetPersonInformation()
    {
        return $"Tools: {_tools}, {GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        return 350000.00;
    }
}