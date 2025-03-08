public class Teacher : Staff
{
    private string _roomNumber;

    public Teacher(string firstName, string lastName, string gender, string roomNumber) :base(firstName, lastName, gender)
    {
        _roomNumber = roomNumber;
    }
    public string Greeting()
    {
        return $"{GreetingTemplate()} I teach in room {_roomNumber}.";
    }
}