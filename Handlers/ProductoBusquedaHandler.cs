using ShopApp.DataAcces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Handler
{
    internal class ProductoBusquedaHandler : SearchHandler
    {
        ShopDbContext dbContext;

        public ProductoBusquedaHandler()
        {
            this.dbContext = new ShopDbContext();
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
                return;
            }

            var productos = dbContext.Products
                .Where(p => p.Nombre.Contains(newValue))
                .ToList();
            ItemsSource = productos;
        }
    }
}