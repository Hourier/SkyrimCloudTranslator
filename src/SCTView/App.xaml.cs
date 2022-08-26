using Prism.Ioc;
using SCTView.Views;
using System.Windows;

namespace SCTView;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override Window CreateShell() => this.Container.Resolve<MainWindow>();

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }
}
