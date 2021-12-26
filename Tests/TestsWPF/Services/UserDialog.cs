using MathCore.DI;
using MathCore.WPF.Services;

using TestsWPF.Services.Interfaces;

namespace TestsWPF.Services;

[Service(Interface = typeof(IUserDialog))]
public class UserDialog : UserDialogService, IUserDialog
{

}