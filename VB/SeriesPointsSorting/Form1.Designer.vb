Namespace SeriesPointsSorting
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim stackedBarSeriesView1 As New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.gspDataSet = New SeriesPointsSorting.gspDataSet()
            Me.gSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gSPTableAdapter = New SeriesPointsSorting.gspDataSetTableAdapters.GSPTableAdapter()
            DirectCast(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(stackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gspDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.DataAdapter = Me.gSPTableAdapter
            Me.chart.DataBindings = Nothing
            Me.chart.DataSource = Me.gSPBindingSource
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesDataMember = "Year"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
            Me.chart.SeriesTemplate.ArgumentDataMember = "Region"
            Me.chart.SeriesTemplate.ValueDataMembersSerializable = "GSP"
            stackedBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chart.SeriesTemplate.View = stackedBarSeriesView1
            Me.chart.Size = New System.Drawing.Size(640, 360)
            Me.chart.TabIndex = 0
            chartTitle1.Text = "GDP By Region"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' gspDataSet
            ' 
            Me.gspDataSet.DataSetName = "gspDataSet"
            Me.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gSPBindingSource
            ' 
            Me.gSPBindingSource.DataMember = "GSP"
            Me.gSPBindingSource.DataSource = Me.gspDataSet
            ' 
            ' gSPTableAdapter
            ' 
            Me.gSPTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(640, 360)
            Me.Controls.Add(Me.chart)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(stackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gspDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chart As DevExpress.XtraCharts.ChartControl
        Private gSPTableAdapter As gspDataSetTableAdapters.GSPTableAdapter
        Private gspDataSet As gspDataSet
        Private gSPBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace

