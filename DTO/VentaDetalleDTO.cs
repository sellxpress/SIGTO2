using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VentaDetalleDTO
    {
        private int idventadetalle;
        private decimal preciounitario;
        private int nroarticulos;
        private int idventa;
        private int idarticulo;
        private int stock;
        private string nombrearticulo;

        public VentaDetalleDTO(int idventadetalle, decimal preciounitario, int nroarticulos, int idventa, int idarticulo)
        {
            this.idventadetalle = idventadetalle;
            this.preciounitario = preciounitario;
            this.nroarticulos = nroarticulos;
            this.idventa = idventa;
            this.idarticulo = idarticulo;

        }
        public VentaDetalleDTO(int idventadetalle, string nombrearticulo, int nroarticulos, decimal preciounitario, int stock, int idventa, int idarticulo)
        {
            this.idventadetalle = idventadetalle;
            this.nroarticulos = nroarticulos;
            this.idventa = idventa;
            this.idarticulo = idarticulo;
            this.nombrearticulo = nombrearticulo;
            this.preciounitario = preciounitario;
            this.stock = stock;
        }

        public int Idventadetalle { get { return this.idventadetalle; } }
        public decimal Preciounitario { get { return this.preciounitario; } }
        public int Nroarticulos { get { return this.nroarticulos; } }
        public int Idarticulo { get { return this.idarticulo; } }
        public int Stock { get { return this.stock; } }
        public int Idventa { get { return this.idventa; } }
        public string NombreArticulo { get { return this.nombrearticulo; } }

    }
    }
    
