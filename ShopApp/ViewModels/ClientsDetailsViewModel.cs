using ShopApp.DataAcces;

namespace ShopApp.ViewModels;

public partial class ClientsDetailViewModel : ViewModelGlobal
{

    [ObservableProperty]
    private string nombreCliente = string.Empty;

    [ObservableProperty]
    private string direccionCliente = string.Empty;

    public void CargarCliente(int id)
    {
        using var database = new ShopDbContext();

        var cliente = database.Clients
            .FirstOrDefault(x => x.Id == id);

        if (cliente != null)
        {
            nombreCliente = cliente.Nombre;
            direccionCliente = cliente.Direccion;
        }
        else
        {
            nombreCliente = "Cliente no encontrado";
            direccionCliente = string.Empty;
        }
    }
}