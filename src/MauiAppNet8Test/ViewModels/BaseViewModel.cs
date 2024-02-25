using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;

namespace MauiAppNet8Test.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        IDispatcher dispatcher;

        [ObservableProperty]
        string someText = string.Empty;
        partial void OnSomeTextChanged(string value)
        {
            Debug.WriteLine($"Text changed to `{value}`");
        }

        [ObservableProperty]    
        int someInt = 0;
        #endregion

        #region Ctor
        public BaseViewModel(IDispatcher dispatcher)
        {
            Dispatcher = dispatcher;
        }
        #endregion
    }
}
