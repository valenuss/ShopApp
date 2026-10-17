using System.Collections.ObjectModel;
using ShopApp.DataAcces;

namespace ShopApp.Views;

public partial class HelpSupportDetailPage : ContentPage
{
    public HelpSupportDetailPage()
    {
        InitializeComponent();
    }
}

public class HelpSupportDetailData : BindingUtilObject
{
    public HelpSupportDetailData()
    {
        var database = new ShopDbContext();
        Products = new ObservableCollection<Product>(database.Products);
    }

    private ObservableCollection<Product> _products;
    public ObservableCollection<Product> Products
    {
        get => _products;
        set
        {
            if (_products != value)
            {
                _products = value;
                ReisePropertyChanged();
            }
        }
    }

    private Product _selectedProduct;
    public Product SelectedProduct
    {
        get => _selectedProduct;
        set
        {
            if (_selectedProduct != value)
            {
                _selectedProduct = value;
                ReisePropertyChanged();
            }
        }
    }

    private int _amount;
    public int Amount
    {
        get => _amount;
        set
        {
            if (_amount != value)
            {
                _amount = value;
                ReisePropertyChanged();
            }
        }
    }
}