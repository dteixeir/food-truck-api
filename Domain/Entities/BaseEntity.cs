using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain
{
  public class BaseEntity {
    [Key]
    public Guid Id {get; set;}

    public DateTime CreateDateTime {get; set;}

    public Guid CreateUserId {get; set;}

    public User CreateUser {get; set;}
    [ForeignKey("CreateUserId")]
    public DateTime? UpdateDateTime {get; set;}

    public Guid? UpdateUserId {get; set;}
    [ForeignKey("UpdateUserId")]
    public User UpdateUser {get; set;}

    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
  }
}