using System.Collections.ObjectModel;
using System.ComponentModel;
using ShopApp.DataAcces;
using ShopApp.Views;

namespace ShopApp.ViewModels;

public partial class HelpSupportViewModel : ViewModelGlobal
{

    [ObservableProperty]
    private int visitasPendientes;

    [ObservableProperty]
    private ObservableCollection<Client> clients = new();

    [ObservableProperty]
    private Client? clienteSeleccionado;


    private readonly INavegacionService _navegacionService;

    public Action<object?, PropertyChangedEventArgs> PropertyChanged { get; }

    internal HelpSupportViewModel(INavegacionService navegacionService)
    {
        _navegacionService = navegacionService;

        using var database = new ShopDbContext();

        clients = new ObservableCollection<Client>(
            database.Clients.ToList()
        );

        PropertyChanged += HelpSupportData_PropertyChanged;
    }

    private async void HelpSupportData_PropertyChanged(
        object? sender,
        PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(clienteSeleccionado)
            && clienteSeleccionado != null)
        {
            var uri =
                $"{nameof(HelpSupportDetailPage)}?id={clienteSeleccionado.Id}";

            await _navegacionService.GoToAsync(uri);
        }
    }
}

internal interface INavegacionService
{
    Task GoToAsync(string uri);
}