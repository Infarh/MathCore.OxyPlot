using MathCore;
using MathCore.Statistic;

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.ImageSharp;
using OxyPlot.Series;

namespace TestsConsole;

public static class HistogramTest
{
    public static void Run()
    {
        var rnd = new RandomNormal();

        var data = rnd.SequenceDouble(100000).ToArray();

        var histogram = new Histogram(data, 10);

        var model = new PlotModel
        {
            Axes =
            {
                new CategoryAxis
                {
                    Position = AxisPosition.Bottom,
                    ItemsSource = histogram,
                },
                new LinearAxis
                {
                    Position = AxisPosition.Left,
                },
            },
            Series =
            {
                new HistogramSeries
                {
                    ItemsSource = histogram,
                    Mapping = v =>
                    {
                        var (min, max, value) = (ValuedInterval<double>)v;
                        var count = (int)(value * 10000);
                        return new HistogramItem(min, max, value, count);
                    }
                }
            }
        };

        var png = new FileInfo("histogram.png");


        var png_encoder = new PngExporter(800, 600);
        using (var png_stream = png.Create())
            png_encoder.Export(model, png_stream);

        png.ShowInExplorer();

        //Console.ReadLine();
        
    }
}