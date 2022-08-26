using Prism.Mvvm;

namespace SCTView.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private string title = "Prism Application";

    public string Title
    {
        get => this.title;
        set => this.SetProperty(ref this.title, value);
    }

    public MainWindowViewModel()
    {
    }
}
