using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anket.Models;

public class Userr
{
    public Userr() { }
   public Userr(string name, string surName, string email, string number, DateTime birthdate)
    {
        Name = name;
        SurName = surName;
        Email = email;
        Number = number;
        Birthdate = birthdate;
    }

    public string Name { get; set; }
    public string SurName { get; set; }
    public string Email { get; set; }
    public string Number { get; set; }
    public DateTime Birthdate { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
