using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TravellingViajes.Data
{
    public class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            // Patrón de expresión regular para validar un correo electrónico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Comprueba si la cadena coincide con el patrón
            return Regex.IsMatch(email, pattern);
        }
    }
}
