using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentaDetalleDTO
    {
        private int idventadetalle;
        private decimal preciounitario;
        private int nroarticulos;
        private int idventa;
        private int idarticulo;

        public VentaDetalleDTO(int idventadetalle, decimal preciounitario, int nroarticulos, int idventa, int idarticulo)
        {
            this.idventadetalle = idventadetalle;
            this.preciounitario = preciounitario;
            this.nroarticulos = nroarticulos;
            this.idventa = idventa;
            this.idarticulo = idarticulo;

        }
        public int Idventadetalle { get { return this.idventadetalle; } }
        public decimal Preciounitario { get { return this.preciounitario; } }
        public int Nroarticulos { get { return this.nroarticulos; } }
        public int Idarticulo { get { return this.idarticulo; } }
        public int Idventa { get { return this.idventa; } }


    }
    }
