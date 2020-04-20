using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLogin.Models
{
  public class EmployeeViewModel
  {

    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public Nullable<int> DId { get; set; }
    public string Address { get; set; }
  }
}
