using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triangles.Providers
{
    public class CoordinatesProvider
    {


        public static string CalculateCoordinates(string row, int column)
        {
            if (column % 2 == 0)
            { return "even column"; }
            return "odd column"; ;
        }

       
    }

}