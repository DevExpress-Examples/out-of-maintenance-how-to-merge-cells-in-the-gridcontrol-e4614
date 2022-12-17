Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication88

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim customers As ObservableCollection(Of Product) = New ObservableCollection(Of Product)()
            customers.Add(New Product() With {.ID = 0, .Name = "Product1", .Category = "Category1"})
            customers.Add(New Product() With {.ID = 1, .Name = "Product2", .Category = "Category1"})
            customers.Add(New Product() With {.ID = 2, .Name = "Product3", .Category = "Category2"})
            customers.Add(New Product() With {.ID = 3, .Name = "Product4", .Category = "Category2"})
            customers.Add(New Product() With {.ID = 4, .Name = "Product5", .Category = "Category1"})
            customers.Add(New Product() With {.ID = 5, .Name = "Product6", .Category = "Category3"})
            Me.grid.ItemsSource = customers
        End Sub
    End Class

    Public Class Product

        Public Property ID As Integer

        Public Property Name As String

        Public Property Category As String
    End Class
End Namespace
