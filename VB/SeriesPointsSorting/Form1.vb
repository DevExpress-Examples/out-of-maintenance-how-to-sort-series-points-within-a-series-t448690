Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace SeriesPointsSorting
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#SeriesPointSorting"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.gSPTableAdapter.Fill(Me.gspDataSet.GSP)

            Dim seriesTemplate As SeriesBase = chart.SeriesTemplate
            seriesTemplate.SeriesPointsSorting = SortingMode.Ascending
            seriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Value_1
        End Sub
        #End Region ' #SeriesPointSorting
    End Class
End Namespace
