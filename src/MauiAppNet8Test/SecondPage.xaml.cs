using MauiAppNet8Test.ViewModels;

namespace MauiAppNet8Test
{
    public partial class SecondPage : ContentPage
    {
        int count = 0;

        public SecondPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            // https://learn.microsoft.com/en-us/dotnet/architecture/maui/dependency-injection#resolution
            BindingContext = viewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
