using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triangles.Providers
{
    public class LocationProvider
    {
        /*
         * The y coordinates from V2 and V3 will narrow down row so starting with those
         * 
         */
        public static string LocateTriangle(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            string row = CalculateRow(v3y / 10);
            string column = CalculateColumn(v1x,v3x);
            return string.Format("Triangle Location: {0}{1}", row.ToUpper(), column);
        }

        private static string CalculateRow(int row)
        {
            switch (row)
            {
                case 1:
                    return "a";
                case 2:
                    return "b";
                case 3:
                    return "c";
                case 4:
                    return "d";
                case 5:
                    return "e";
                case 6:
                    return "f";
                default:
                    return string.Empty;

            }
        }

        private static string CalculateColumn(int v1x,  int v3x)
        {
            int column = (v1x * 2) / 10;
            if(column == 0 || v3x>v1x)
            {
                column++;
            }
            return column.ToString();
        }
    }
}