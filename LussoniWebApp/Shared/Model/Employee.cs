using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LussoniWebApp.Shared.Model;

public class Employee : Entity
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? IdNumber { get; set; }

}
