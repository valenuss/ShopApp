using Microsoft.EntityFrameworkCore;

namespace ShopApp.ViewModels;

public partial class ResumenViewModel : ViewModelGlobal
{
    [ObservableProperty]
    private int visitas;

    [ObservableProperty]
    private decimal total;

    [ObservableProperty]
    private int clients;

    public object TotalProducts { get; }

    [ObservableProperty]
    private int totalProducts;

    public ResumenViewModel(ShopOutDbContext shopOutDbContext)
    {
        var compras = shopOutDbContext.Compras
            .AsNoTracking()
            .ToList();

        Visitas = compras.Count;

        Total = compras.Sum(
            static c => c.Cantidad * c.Precio);

        clients = compras
            .Select(c => c.ClienteId)
            .Distinct()
            .Count();

        TotalProducts = compras.Sum(
            static c => c.Cantidad);
    }

    public int Visitas { get; }
    public object Total { get; }
}

public class ShopOutDbContext
{
    public object Compras { get; internal set; }

    internal async Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}