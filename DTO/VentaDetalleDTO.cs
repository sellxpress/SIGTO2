using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentaDetalleDTO
    {
        private string idventadetalle;
        private string preciounitario;
        private string nroarticulos;
        private string idventa;
        private string idarticulo;

        public VentaDetalleDTO(string idventadetalle, string preciounitario, string nroarticulos, string idventa, string idarticulo)
        {
            this.idventadetalle = idventadetalle;
            this.preciounitario = preciounitario;
            this.nroarticulos = nroarticulos;
            this.idventa = idventa;
            this.idarticulo = idarticulo;

        }
    }
    }
