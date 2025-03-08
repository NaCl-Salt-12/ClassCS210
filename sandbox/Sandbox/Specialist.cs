public class Specialist: Staff
{
    private string _specialty;

    public Specialist(string firstName, string lastName, string gender, string _specialty) :base(firstName, lastName, gender)
    {
        this._specialty = _specialty;
    }
    public string Greeting()
    {
        return $"{GreetingTemplate()} I am a {_specialty}.";
    }
}