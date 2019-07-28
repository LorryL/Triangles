using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Triangles.Providers;

namespace Triangles.Controllers
{
    public class ValuesController : ApiController
    {

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int column, string row)
        {
            InputValidationProvider.ValidateUserInput(row, column);
            return CoordinatesProvider.CalculateCoordinates(row, column);
        }

    }
}
