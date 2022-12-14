using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  { 
    public void Dispose()
    {
      Place.ClearAll();
    }
    // Test methods go here
    [TestMethod]
    public void PlaceConstructor_ItWillCreateInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetProperty_ItWillReturnCityNameProperty_String()
    {
      string userInput = "Los Angeles";
      Place newPlace = new Place(userInput);
      Assert.AreEqual(userInput, newPlace.CityName);
    }

    [TestMethod]
    public void GetList_ItReturnsEmptyList_List()
    {
      List<Place> expected = new List<Place> {};
      CollectionAssert.AreEqual(expected, Place.GetPlaces());
    }

    [TestMethod]
    public void GetId_ItReturnsUniqueId_Int()
    {
      string userInput = "Seattle";
      Place newPlace = new Place(userInput);
      int result = 1;
      Assert.AreEqual(result, newPlace.Id);
    }

    [TestMethod]
    public void Find_ItReturnsSpecifiedObject_Place()
    {
      string userInput = "Los Angeles";
      Place newPlace = new Place(userInput);
      Place result = Place.Find(1);
      Assert.AreEqual(result, newPlace);
    }
  }
}