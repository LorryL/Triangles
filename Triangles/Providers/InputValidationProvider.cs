using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triangles.Providers
{
    public class InputValidationProvider
    {
        static string[] validInputRows = new string[] { "a", "b", "c", "d", "e", "f", };

        public static void ValidateUserInput(string row, int column)
        {
            if (!ValidateColumnInput(column))
            {
                throw new Exception("Please enter a column number between 1 and 12");
            }
            if (!ValidateRowInput(row))
            {
                throw new Exception("Please enter a row letter between a and f");
            }
        }


        private static bool ValidateColumnInput(int column)
        {
            bool validInput = false;
            if (column >= 1 && column <= 12)
            {
                validInput = true;
            }
            return validInput;
        }

        private static bool ValidateRowInput(string row)
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