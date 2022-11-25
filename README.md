# How-to-create-a-dotted-line-chart-in-.NET-MAUI-Chart
A line chart with dots or dashes is commonly used to display forecast values. They are outstanding for visualizing estimates or uncertainty.

.NET MAUI Chart allows you to create a line chart with dashes by using the StrokeDashArray property of the LineSeries, as shown in the following code example. This property requires an array, where the odd value represents the rendering size, and the even value represents the gap.

**[XAML]**

```
xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
 
<chart:SfCartesianChart>
    
    <chart:SfCartesianChart.BindingContext>
        <local:ViewModel></local:ViewModel>
    </chart:SfCartesianChart.BindingContext>
    
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis></chart:CategoryAxis>
    </chart:SfCartesianChart.XAxes>
    
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis EdgeLabelsDrawingMode="Shift" Minimum="0">
            <chart:NumericalAxis.LabelStyle>
                <chart:ChartAxisLabelStyle LabelFormat="0B"></chart:ChartAxisLabelStyle>
            </chart:NumericalAxis.LabelStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>
    
    <chart:SfCartesianChart.Legend>
        <chart:ChartLegend></chart:ChartLegend>
    </chart:SfCartesianChart.Legend>

    <chart:SfCartesianChart.Series>
        <chart:LineSeries ShowDataLabels="True" Label="Projected Revenue" StrokeWidth="2" 
                                        Fill="#512BD4" ItemsSource="{Binding Data}" 
                                        XBindingPath="Year" YBindingPath="Revenue">
            <chart:LineSeries.DataLabelSettings>
                <chart:CartesianDataLabelSettings>
                    <chart:CartesianDataLabelSettings.LabelStyle>
                        <chart:ChartDataLabelStyle FontSize="10" LabelFormat="0B">
                        </chart:ChartDataLabelStyle>
                    </chart:CartesianDataLabelSettings.LabelStyle>
                </chart:CartesianDataLabelSettings>
            </chart:LineSeries.DataLabelSettings>

            <chart:LineSeries.StrokeDashArray>
                <DoubleCollection>
                    <x:Double>2</x:Double>
                    <x:Double>2</x:Double>
                </DoubleCollection>
            </chart:LineSeries.StrokeDashArray>

        </chart:LineSeries>
    </chart:SfCartesianChart.Series>

</chart:SfCartesianChart>
```

**[C#]**

```
using Syncfusion.Maui.Charts;

SfCartesianChart chart = new SfCartesianChart();
chart.BindingContext = new ViewModel();
CategoryAxis xAxis = new CategoryAxis();
NumericalAxis yAxis = new NumericalAxis();
yAxis.LabelStyle = new ChartAxisLabelStyle()
{
	LabelFormat = "0B"
};

chart.XAxes.Add(xAxis);
chart.YAxes.Add(yAxis);

LineSeries lineSeries = new LineSeries();
chart.Series.Add(lineSeries);

lineSeries.ItemsSource = new ViewModel().Data;
lineSeries.XBindingPath = "Year";
lineSeries.YBindingPath = "Revenue";
lineSeries.ShowDataLabels = true;
lineSeries.Fill = Color.FromArgb("#512BD4");
lineSeries.StrokeWidth = 2;
lineSeries.StrokeDashArray = new DoubleCollection() { 2, 2 };

CartesianDataLabelSettings dataLabelSettings = new CartesianDataLabelSettings();
dataLabelSettings.LabelStyle = new ChartDataLabelStyle()
{
	LabelFormat = "0B"
};
lineSeries.DataLabelSettings = dataLabelSettings;

Content = chart;
```

**[Output]**

<img width="709" alt="maui_charts_dotted_line_chart" src="https://user-images.githubusercontent.com/105496256/203955482-909a997c-a799-4efb-8e78-0e57d2dbcb5f.PNG">

