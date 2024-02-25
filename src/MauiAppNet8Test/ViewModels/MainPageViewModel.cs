using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;

namespace MauiAppNet8Test.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        #region Properties
        [ObservableProperty]
        new string someText = string.Empty;
        partial void OnSomeTextChanged(string value)
        {
            Debug.WriteLine($"Text changed to `{value}`");
        }
        #endregion

        #region Ctor
        public MainPageViewModel(IDispatcher dispatcher) : base(dispatcher)
        {
            Dispatcher = dispatcher;
        }
        #endregion
    }
}
