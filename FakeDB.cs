using System.Collections.Generic;
using gregslist_csharp.Models;

namespace gregslist_csharp
{
  static public class FakeDB
  {
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("VW", "Bug", 1973, 1000, "Groovy!", "https://c1.wallpaperflare.com/preview/154/893/184/old-car-vintage-vw.jpg") };
  }
}