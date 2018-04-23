Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfApplication88
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            Dim customers As New ObservableCollection(Of Product)()
            customers.Add(New Product() With {.ID = 0, .Name = "Product1", .Category = "Category1"})
            customers.Add(New Product() With {.ID = 1, .Name = "Product2", .Category = "Category1"})
            customers.Add(New Product() With {.ID = 2, .Name = "Product3", .Category = "Category2"})
            customers.Add(New Product() With {.ID = 3, .Name = "Product4", .Category = "Category2"})
            customers.Add(New Product() With {.ID = 4, .Name = "Product5", .Category = "Category1"})
            customers.Add(New Product() With {.ID = 5, .Name = "Product6", .Category = "Category3"})
            grid.ItemsSource = customers
        End Sub
    End Class

    Public Class Product
        Public Property ID() As Integer

        Public Property Name() As String
        Public Property Category() As String
    End Class
End Namespace
