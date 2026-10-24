using ShopApp.DataAcces;

namespace ShopApp.Views;

public partial class ProductsPage : ContentPage
{
    public ProductsPage()
    {
        InitializeComponent();

        using var dbContext = new ShopDbContext();

        foreach (var product in dbContext.Products)
        {
            var boton = new Button
            {
            {
                var uri = $"{nameof(ProductDetailPage)}?id={productId}";
                await Shell.Current.GoToAsync(uri);
            };
            container.Children.Add(boton);
        }
    }
}