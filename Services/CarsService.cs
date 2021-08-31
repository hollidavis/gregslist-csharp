using System;
using System.Collections.Generic;
using gregslist_csharp.Models;

namespace gregslist_csharp.Services
{
  public class CarsService
  {
    internal IEnumerable<Car> Get()
    {
       return FakeDB.Cars;
    }
     internal Car Get(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
  }
}