using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain
{
  public class FoodTruck : BaseEntity
  {
    public string Name { get; set; }

    public Guid CompanyId { get; set; }
    [ForeignKey("CompanyId")]
    public Company Company { get; set; }

    public Menu Menu { get; set; }

    public ICollection<ScheduleItem> ScheduleItems { get; set; }
  }
}