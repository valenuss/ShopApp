namespace ShopApp.ViewModels
{
    internal class CompraItem
    {
        internal object ClienteId;
        internal object ProductId;
        internal object Cantidad;
        internal object Precio;
        private int clienteId;
        private int productId;
        private int cantidad;
        private decimal precio;

        public CompraItem(int clienteId, int productId, int cantidad, decimal precio)
        {
            this.clienteId = clienteId;
            this.productId = productId;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
}