
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

using TestsConsole.Models;

const int N = 100;
static IEnumerable<DataValue> Values(Func<double, double> f) =>
    Enumerable.Range(0, N)
       .Select(i => (double)i / (N - 1))
       .Select(x => new DataValue { X = x, Y = f(x) });

static LineSeries Series(string Name, Func<double, double> f, OxyColor Color) => new()
{
    Title = Name,
    DataFieldX = "X",
    DataFieldY = "Y",
    Color = Color,
    ItemsSource = Values(f),
};

var model = new PlotModel
{
    Title = "Гармонические функции",
    Background = OxyColors.White,
    Axes =
    {
        new LinearAxis
        {
            Position = AxisPosition.Bottom,
            Title = "X",
            MinorGridlineColor = OxyColors.LightGray,
            MinorGridlineStyle = LineStyle.Dot,
            MajorGridlineColor = OxyColors.Gray,
            MajorGridlineStyle = LineStyle.Dash,
        },
        new LinearAxis
        {
            Position = AxisPosition.Left,
            Title = "Y",
            MinorGridlineColor = OxyColors.LightGray,
            MinorGridlineStyle = LineStyle.Dot,
            MajorGridlineColor = OxyColors.Gray,
            MajorGridlineStyle = LineStyle.Dash,
        },
    },
    Series =
    {
        Series("Sin", x => Math.Sin(2 * Math.PI * x), OxyColors.Red),
        Series("Sin", x => Math.Cos(2 * Math.PI * x), OxyColors.Blue),
    }
};

var png_encoder = new OxyPlot.ImageSharp.PngExporter(800, 600);
var svg_encoder = new SvgExporter { Width = 800, Height = 600 };


var png = new FileInfo("graph.png");
var svg = new FileInfo("graph.svg");


using (var png_stream = png.Create())
    png_encoder.Export(model, png_stream);

using (var svg_srteam = svg.Create())
    svg_encoder.Export(model, svg_srteam);

//graph.Execute();
//graph.ShowInFileExplorer();

//Console.ReadLine();
