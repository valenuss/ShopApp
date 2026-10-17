using System.ComponentModel;

namespace ShopApp.Views;

public partial class HelpSupportPage : INotifyPropertyChanged
{
    public HelpSupportPage()
    {
        InitializeComponent();
    }

    public int _visitCount;

    public int visitCount
    {
        get { return _visitCount; }
        set
        {
            _visitCount = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(visitCount)));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void Button_Clicked(object sender, EventArgs e)
    {
        var dataObject = Resources["data"] as HelpSupportData;
        dataObject.VisitCount = 30;
    }
}