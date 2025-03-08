public class Volunteer: Staff
{

    public Volunteer(string firstName, string lastName, string gender) :base(firstName, lastName, gender)
    {

    }
    public string Greeting()
    {
        return $"{GreetingTemplate()} I am a volunteer at the school.";
    }
}