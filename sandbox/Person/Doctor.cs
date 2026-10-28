using System.Security.Cryptography;

class Doctor: Person
{
    private string _tools;

    public Doctor(string firstname, string lastname, int age, double weight, string tools)
    :base(firstname, lastname, age, weight)
    {
        _tools = tools;
    }

    public string GetDoctorInformation()
    {
        return $"Tools: {_tools}, {GetPersonInformation()}";
    }
}