namespace ShopApp.Views;

public partial class HelpSupportData : BndingUtilObject
{
	public int _visitCount;

	public int visitcount
	{

        get { return _visitCount; }
		set
        {
            _visitCount = value;
           ReisePropertyChanged();
        }
    }
}