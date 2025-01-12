namespace Address;

public class Address
{
     private string _streetname;
    private int _housenumber;
    private int _plz;
    private string _cityName;

    public string CityName 
    {
        get 
        {
            return _cityName;
        }
        set
        {
            _cityName = value;
        }
    }

    public int PLZ
    {
        get
        {
            return _plz;
        }
        set
        {
            _plz = value;
        }
    }

    public string Streetname
    {
        get
        {
            return _streetname;
        }
        set
        {
            _streetname = value;
        }
    }

    public int Housenumber
    {
        get
        {
            return _housenumber;
        }
        set
        {
            _housenumber = value;
        }
    }

    public Address(string streetname, int housenumber, int plz, string cityName)
    {
        _streetname = streetname;
        _housenumber = housenumber;
        _plz = plz;
        _cityName = cityName;
    }

    public string FullAdress()
    {
        string housenum = Convert.ToString(_housenumber);
        string plz = Convert.ToString(_plz);
        return _streetname + " " + housenum + ",  " + plz + " " + _cityName;
    }

}
