using MathCore.Hosting.WPF;

using TestsWPF.ViewModels;

namespace TestsWPF;

public class ServicesLocator : ServiceLocatorHosted
{
    public MainWindowViewModel MainModel => GetRequiredService<MainWindowViewModel>();
}