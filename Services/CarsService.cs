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
  }
}