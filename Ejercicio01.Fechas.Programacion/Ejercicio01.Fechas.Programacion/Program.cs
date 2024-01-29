using System.Globalization;
using System.Reflection;

namespace Ejercicio01.Fechas.Programacion
{




    class Program
    {

       public static void Main(string[] args)
        {



            // Fecha Del Sistema
            DateTime fechaDelSistema = DateTime.Now;
            Console.WriteLine(fechaDelSistema);


            // Formateo de la fecha
            DateTimeFormatInfo formatoEspañol = CultureInfo.GetCultureInfo("en-ES").DateTimeFormat;
            Type tipoFormato = formatoEspañol.GetType();
            PropertyInfo[] proiedadesFormatoEspanol = tipoFormato.GetProperties(); 
        

            foreach (var propiedadFecha in proiedadesFormatoEspanol)
            {

                if (propiedadFecha.Name.Contains("Pattern"))
                {

                    string formaFecha = propiedadFecha.GetValue(formatoEspañol, null).ToString();
                    Console.WriteLine(propiedadFecha.Name + ": " + formaFecha + " " +
                              fechaDelSistema.ToString(formaFecha));


                }

            }

            //Formato Especifico
            Console.WriteLine("Formato fecha-tiempo: " + fechaDelSistema);
            

            
        }

    }
}