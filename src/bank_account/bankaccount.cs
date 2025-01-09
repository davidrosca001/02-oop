namespace bankaccount;

using Person;
using Adress;

public class Bankaccount
{
 //Attribute
 private Person _accountowner = new Person();
 private int _bankBalance;
 private int _payOutsum;
 private int _payInsum;

   //Probertys

    public int BankBalance
    {
        get
        {
            return _bankBalance;
        }
        set
        {
            _bankBalance = value;
        }
    }

    public int SetPayOut
    {
        get
        {
            return _payOutsum;
        }
        set
        {
            _payOutsum = value;
        }
    }

    public int SetPayIn
    {
        get
        {
            return _payInsum;
        }
        set
        {
            _payInsum = value;
        }
    }


    public string BankingFirstName
    {
        get
        {
            return _accountowner.Firstname;
        }
        set
        {
            _accountowner.Firstname = value;
        }
    }

    public string BankingSecondName
    {
        get
        {
            return _accountowner.SecondName;
        }
        set
        {
            _accountowner.SecondName = value;
        }
    }

    public string OwnerStreetName
    {
        get
        {
            return _ownerAddress.Streetname;
        }
        set
        {
            _ownerAddress.Streetname = value;
        }
    }

    public int OwnerHouseNumber
    {
        get
        {
            return _ownerAddress.Housenumber;
        }
        set
        {
            _ownerAddress.Housenumber = value;
        }
    }

    public int OwnerPLZ
    {
        get
        {
            return _ownerAddress.PLZ;
        }
        set
        {
            _ownerAddress.PLZ = value;
        }
    }

    public string OwnerCityName
    {
        get
        {
            return _ownerAddress.CityName;
        }
        set
        {
            _ownerAddress.CityName = value;
        }
    }

    public string AccountOwner()
    {
        return _accountowner.Fullname;
    }

    public bool CheckIfCovered()
    {
        if (_bankBalance >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PayOutExecution()
    {
        _bankBalance -= _payOutsum;
    }

    public void PayInExecution()
    {
        _bankBalance += _payInsum;
    }

    public string FullOwnerAddress()
    {
        string housenum = Convert.ToString(_ownerAddress.Housenumber);
        string ownerplz = Convert.ToString(_ownerAddress.PLZ);
        return _ownerAddress.Streetname + " " + housenum + " " + ownerplz + " " +  _ownerAddress.CityName;
    }
}