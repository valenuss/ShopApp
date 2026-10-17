using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Views;

public class HelpSupportData : BindingUtilObject
{
    public int _visitCount;

    public int VisitCount
    {
        get { return _visitCount; }
        set
        {
            _visitCount = value;
            ReisePropertyChanged();
        }
    }
}
