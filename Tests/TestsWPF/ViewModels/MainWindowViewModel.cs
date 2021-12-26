using System.Windows.Markup;

using MathCore.DI;
using MathCore.WPF.ViewModels;

using TestsWPF.Services.Interfaces;

namespace TestsWPF.ViewModels;

[Service][MarkupExtensionReturnType(typeof(MainWindowViewModel))]
public class MainWindowViewModel : TitledViewModel
{
    [Inject]
    private IUserDialog _UserDialog = null!;

    public MainWindowViewModel() => Title = "Главное окно";
}