using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro2026
{
    public static class ApiRotasController
    {
        private static readonly string BaseUrl = "http://127.0.0.1:5000";

        public static string ConsultarSerie_A => $"{BaseUrl}/Serie_A";

        public static string ConsultarSerie_B => $"{BaseUrl}/Serie_B";

        public static string ConsultarSerie_C => $"{BaseUrl}/Serie_C";

        public static string ConsultarSerie_D => $"{BaseUrl}/Serie_D";
    }
}
