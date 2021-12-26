using System.Collections.Generic;
using System.Linq;

using TestsWPF.Models;
using TestsWPF.ViewModels;

namespace TestsWPF.Infrastructure.Mapping;

public static class DataValuesMapper
{
    public static DataValueViewModel? ToView(this DataValue? value) => value is null
        ? null
        : new DataValueViewModel { X = value.X, Y = value.Y };

    public static DataValue? FromView(this DataValueViewModel? value) => value is null
        ? null
        : new DataValue { X = value.X, Y = value.Y };

    public static IEnumerable<DataValueViewModel?> ToView(this IEnumerable<DataValue> values) =>
        values.Select(v => v.ToView());

    public static IEnumerable<DataValue?> FromView(this IEnumerable<DataValueViewModel> values) =>
        values.Select(v => v.FromView());
}