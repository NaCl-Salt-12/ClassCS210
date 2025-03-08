public class Staff
{
    private string _firstName;
    private string _lastName;
    private string _gender;



public Staff(string firstName, string lastName, string gender)
{
    _firstName = firstName;
    _lastName = lastName; 
    _gender = gender;
    }
    public string GreetingTemplate()
    {
        if (_gender == "M")
        {
        return $"Hello students, I am Mr. {_lastName}.";
        }
        if (_gender == "F")
        {
        return $"Hello students, I am Mrs. {_lastName}.";
        }
        else
        {
            throw new ArgumentException("Not a valid Gender");
        }
    }

}
