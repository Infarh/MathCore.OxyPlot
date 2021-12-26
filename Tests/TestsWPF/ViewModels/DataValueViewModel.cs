using System.Windows.Markup;

using MathCore.WPF.ViewModels;

namespace TestsWPF.ViewModels;

[MarkupExtensionReturnType(typeof(DataValueViewModel))]
public class DataValueViewModel : ViewModel
{
    #region X : double - Аргумент

    /// <summary>Аргумент</summary>
    private double _X;

    /// <summary>Аргумент</summary>
    public double X { get => _X; set => Set(ref _X, value); }

    #endregion

    #region Y : double - Значение

    /// <summary>Значение</summary>
    private double _Y;

    /// <summary>Значение</summary>
    public double Y { get => _Y; set => Set(ref _Y, value); }

    #endregion
}