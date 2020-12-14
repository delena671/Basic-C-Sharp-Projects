using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employee
    {
        List<string> Employees = new List<string>()
        {
            "Statton, Nancy ID:0112",
            "Newton, Gregory ID:0114",
            "Opal, Denise ID:0116",
            "Cain, Patti ID:0111",
            "Cruz, Adeline ID:0118",
            "Moran, Mike ID:0109",
            "Johnson, Joe ID:0105",
            "Kim, Soo ID:0008",
            "Davis, Joe ID:0113",
            "Hoyle, Jessica ID:0108"
        };
        List<string> fisrtName = new List<string>()
        {
            "Nancy",
            "Gregory",
            "Denise",
            "Patti",
            "Adeline",
            "Mike",
            "Joe",
            "Soo",
            "Joe",
            "Jessica"
        };

        List<int> employeeID = new List<int>()
        {
            0112,
            0114,
            0116,
            0111,
            0118,
            0109,
            0105,
            0008,
            0113,
            0108
        };
    }
}
