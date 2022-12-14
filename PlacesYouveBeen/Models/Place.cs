using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }

    public int Id { get; }

    static private List<Place> _places = new List<Place> {};

    public Place(string userInputCity)
    {
      CityName = userInputCity;
      _places.Add(this);
      Id = _places.Count;
    }

    public static List<Place> GetPlaces ()
    {
      return _places;
    }

    public static void ClearAll()
    {
      _places.Clear();
    }

    public static Place Find(int id)
    {
      return _places[id - 1];
    }
  }
}