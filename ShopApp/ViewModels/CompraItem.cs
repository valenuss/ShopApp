namespace ShopApp.ViewModels
{
    internal class CompraItem
    {
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