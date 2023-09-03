using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Factura
    {

        private string codigo = "";
        private string producto = "";
        private string PxU = "";
        private string Cantiada = "";
        private string Cliente = "";
        private string Cod_cliente = "";
        private string descuento = "";
        private string PrecioTortal = "";
        private string Subtotal = "";
        private string Total = "";
        private string NFactura = "";

        public string Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public string PxU1 { get => PxU; set => PxU = value; }
        public string Cantiada1 { get => Cantiada; set => Cantiada = value; }
        public string Cliente1 { get => Cliente; set => Cliente = value; }
        public string Subtotal1 { get => Subtotal; set => Subtotal = value; }
        public string Total1 { get => Total; set =>Total = value; }
        public string NFactura1 { get => NFactura; set => NFactura = value; }
        public string Cod_cliente1 { get => Cod_cliente; set => Cod_cliente = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string PrecioTortal1 { get => PrecioTortal; set => PrecioTortal = value; }
    }    
}
