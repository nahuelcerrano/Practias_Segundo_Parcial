namespace SP_Practica
{
    internal class NodoVenta
    {
        public NodoVenta(string codVendedor = "", decimal importeVenta = 0, NodoVenta? siguiente = null)
        {
            CodVendedor = codVendedor;
            ImporteVenta = importeVenta;
            Siguiente = siguiente;
        }

        public string CodVendedor { get; set; }
        public decimal ImporteVenta { get; set; }
        public NodoVenta? Siguiente { get; set; }
    }
}
