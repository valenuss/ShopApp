using System.ComponentModel;

namespace ShopApp.Views;

public partial class HelpSupportPage : INotifyPropertyChanged
{
	public int _visitCount;
	
	public int visitCount
	{ 
		get {  return _visitCount; }
		set {
            _visitCount = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(visitCount)));
        }

    }

	public event PropertyChangedEventHandler PropertyChanged;


    private void Button_Clicked(object sender, EventArgs e)
    {
		var dataObject = Resources ["Data"] as HelpSupportData;
		dataObject.VisitCount = 30;
    }
}

public class HelpSupportData
{ 
	public int VisitCount { get; set; }

}