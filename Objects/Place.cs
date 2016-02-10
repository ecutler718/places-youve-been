using System.Collections.Generic;

namespace Travel.Objects
{
  public class Place
  {
    private string _name;
    private string _country;
    private int _id;
    private static List<Place> _placeInstances = new List<Place> {};

    public Place (string name, string country)
    {
      _name = name;
      _country = country;
      _placeInstances.Add(this);
      _id = _placeInstances.Count;

    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetCountry()
    {
      return _country;
    }
    public void SetCountry(string newCountry)
    {
      _country = newCountry;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Place> GetAll()
    {
      return _placeInstances;
    }
    public static Place Find(int searchId)
    {
      return _placeInstances[searchId-1];
    }
  }
}
