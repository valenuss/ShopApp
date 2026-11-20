using ShopApp.DataAcces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ShopApp.ViewModels;

public partial class ProductDetailViewModel : ViewModelGlobal
{

    [ObservableProperty]
    private string nombre = string.Empty;

    [ObservableProperty]
    private string descripcion = string.Empty;

    [ObservableProperty]
    private decimal precio;

    [ObservableProperty]
    private string imagen = string.Empty;

    public void CargarProducto(int id)
    {
        using var database = new ShopDbContext();

        var producto = database.Products
            .FirstOrDefault(x => x.Id == id);

        if (producto != null)
        {
            nombre = producto.Nombre;
            descripcion = producto.Descripcion;
            precio = producto.Precio;
            imagen = producto.Imagen;
        }
        else
        {
            nombre = "Producto no encontrado";
            descripcion = string.Empty;
            precio = 0;
            imagen = string.Empty;
        }
    }
}

internal class ObservablePropertyAttribute : Attribute
{
}