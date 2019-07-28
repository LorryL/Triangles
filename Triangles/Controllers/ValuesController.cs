using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string[] Get(int column, string row)
        {
            InputValidationProvider.ValidateUserInput(row, column);
            return CoordinatesProvider.CalculateCoordinates(row, column);
        }

        // GET api/values/5
        public string Get(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            InputValidationProvider.ValidateVectorPoints(new[] { v1x, v1y, v2x, v2y, v3x, v3y });
            return LocationProvider.LocateTriangle(v1x, v1y, v2x, v2y, v3x, v3y);
        }

    }
}
