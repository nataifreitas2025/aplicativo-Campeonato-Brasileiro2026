using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro2026
{
    public class ConsultarSerieAModel
    {
        public int idSerie_A {  get; set; }

        public string? NomeClube { get; set; }
        
        public int PontosClube {  get; set; }

        public int PossicaoClube { get; set; }

        public int JogosClube { get; set; }

        public int SaldoGols {  get; set; }

        public int VitoriasClube { get; set; }

        public int EmpateClube { get; set; }

        public int DerrotaClube { get; set; }

        public int GolsProClube { get; set; }

        public int GolsContraClube { get; set; }
    }
}
