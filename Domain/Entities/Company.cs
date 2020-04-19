using System;
using System.Collections.Generic;

namespace api.Domain
{
  public class Company : BaseEntity
  {
    public string Name {get; set;}

    public string Description {get; set;}

    public string WebsiteUrl {get; set;}

    public string ImageUrl {get; set;}

    public ICollection<FoodTruck> FoodTrucks {get; set;}
  }
}