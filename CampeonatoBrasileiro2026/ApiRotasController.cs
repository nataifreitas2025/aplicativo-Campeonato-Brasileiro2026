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





        public static string PesquisarSerie_A => $"{BaseUrl}/Serie_A/Nome/";

        public static string PesquisarSerie_B => $"{BaseUrl}/Serie_B/Nome/";

        public static string PesquisarSerie_C => $"{BaseUrl}/Serie_C/Nome/";

        public static string PesquisarSerie_D => $"{BaseUrl}/Serie_D/Nome/";




        public static string PesquisarPosicao_A => $"{BaseUrl}/Serie_A/Posicao/";

        public static string PesquisarPosicao_B => $"{BaseUrl}/Serie_B/Posicao/";

        public static string PesquisarPosicao_C => $"{BaseUrl}/Serie_C/Posicao/";

        public static string PesquisarPosicao_D => $"{BaseUrl}/Serie_D/Posicao/";
    }
}


