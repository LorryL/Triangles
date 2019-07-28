using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triangles.Providers
{
    public class CoordinatesProvider
    {

        /*
         * Some assumptions made.....
         * 
         * Top left corner is point 0,0 with x axis moving left and y axis moving down.
         * 
         * (V1x,V1y) is the right angled corner
         * (V2x,V2y) is top corner
         * (V3x,V3y) is bottom corner
         * 
         */
        public static string[] CalculateCoordinates(string row, int column)
        {
            string[] triangleCoordinates = new string[3];
            int rowNumber = ConvertRowLetterToNumber(row);

            triangleCoordinates[0] = CalculateV1Coordinates(rowNumber, column);
            triangleCoordinates[1] = CalculateV2Coordinates(rowNumber, column);
            triangleCoordinates[2] = "still to be calculated"; 

            return triangleCoordinates;

        }

        private static int ConvertRowLetterToNumber(string row)
        {
            switch (row)
            {
                case "a":
                    return 1;
                case "b":
                    return 2;
                case "c":
                    return 3;
                case "d":
                    return 4;
                case "e":
                    return 5;
                case "f":
                    return 6;
                default:
                    return 0;
            }
        }

        private static string CalculateV1Coordinates(int row, int column)
        {
            int v1x = (column * 10) / 2;
            int v1y = row * 10 - 10;
            

            if (column % 2 != 0)
            {
                v1x = ((column + 1) * 10) / 2 - 10;
                v1y = row * 10;
            }

            return string.Format("V1({0}, {1})", v1x, v1y);
        }



        private static string CalculateV2Coordinates(int row, int column)
        {
            if (column % 2 != 0)
            {
                column++;
            }

            int v1x = (column * 10) / 2 - 10;
            int v1y = row * 10 - 10;

            return string.Format("V2({0}, {1})", v1x, v1y);
        }
    }
}