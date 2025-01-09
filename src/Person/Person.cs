namespace Person;

public class Person
{
    //Attribute
    private string _firstname;
    private string _secondname;

    public string Firstname
    {
        get
        {
            return _firstname;
        }
        set
        {
            _firstname = value;
        }
    }

    public string SecondName
    {
        get
        {
            return _secondname;
        }
        set
        {
            _secondname = value;
        }
    }

    public string Fullname
    {
        get
        {
            return _firstname + " " + _secondname;
        }
    }
}
