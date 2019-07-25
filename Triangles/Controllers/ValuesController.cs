using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Triangles.Controllers
{
    public class ValuesController : ApiController
    {
        string[] validInputRows =  new string [] { "a", "b", "c", "d", "e", "f", };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // localhost:50122/api/values/get

        // GET api/values/5
        public string Get(int column, string row)
        {
            if (!ValidateColumnInput(column))
            {
                throw new Exception("Please enter a column number between 1 and 12");
            }
            if (!ValidateRowInput(row))
            {
                throw new Exception("Please enter a row letter between a and f");
            }
            return "my test";
        }

        private bool ValidateColumnInput(int column)
        {
            bool validInput = false;
            if (column >= 1 && column <=12)
            {
                validInput = true;
            }
            return validInput;
        }

        private bool ValidateRowInput(string row)
        {
            bool validInput = false;
            if (validInputRows.Contains(row))
            {
                validInput = true;
            }
            return validInput;
        }
    }
}
