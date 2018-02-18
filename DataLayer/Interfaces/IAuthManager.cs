using System;
using System.Collections.Generic;
using api.Domain;

namespace api.DataLayer.Interfaces
{
  public interface IAuthManager
  {
    string Authenticate(string username, string password);

    User Put(User items);

    User Register(User item);
  }
}
