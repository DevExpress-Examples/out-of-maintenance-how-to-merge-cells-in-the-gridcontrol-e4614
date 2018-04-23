' Developer Express Code Central Example:
' How to merge cells in the GridControl
' 
' This example demonstrates how to achieve the merged cells effect in the
' GridControl. The main idea consists of stretching the top merged cell and
' showing it over other merged cells. For this purpose, the Panel.ZIndex and
' Margin properties are used.
' Please take special note that this example doesn't
' support editing cells. This example is designed for the DeepBlue theme and may
' need to be modified if you wish to use it in other themes.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4614


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports DevExpress.Xpf.Core

Namespace CellMerging
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private customers As New ObservableCollection(Of Customer)()
		Public Sub New()
			InitializeComponent()
			Dim customers As New ObservableCollection(Of Customer)()
			customers.Add(New Customer() With {.ID = 0, .Name = "Name0"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name0"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			customers.Add(New Customer() With {.ID = 1, .Name = "Name1"})
			gridControl1.ItemsSource = customers
			Me.InvalidateArrange()
		End Sub
	End Class

	Public Class MyTemplateSelector
		Inherits DataTemplateSelector
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim cellEditor As CellEditor = TryCast(container, CellEditor)
			Dim cellData As EditGridCellData = TryCast(item, EditGridCellData)
			If cellData.Column.FieldName <> "Name" Then
				cellEditor.Margin = New Thickness(0, 0, 0, 0)
				Return MyBase.SelectTemplate(item, container)
			End If
			Dim view As TableView = TryCast(cellData.View, TableView)

			TryMerge(cellEditor, cellData, view.Grid.GetRowVisibleIndexByHandle(cellData.RowData.RowHandle.Value))
			Return MyBase.SelectTemplate(item, container)
		End Function
		Protected Function TryMerge(ByVal container As CellEditor, ByVal cellData As EditGridCellData, ByVal curIndex As Integer) As Boolean
			Dim mergCount As Integer = 0
			Dim grid As GridControl = (CType(cellData.View, TableView)).Grid

			For i As Integer = curIndex + 1 To grid.VisibleRowCount - 1
				Dim nextRH As Integer = grid.GetRowHandleByVisibleIndex(i)
				If Object.Equals(grid.GetCellValue(nextRH, CType(cellData.Column, GridColumn)), cellData.Value) AndAlso nextRH > 0 Then
					mergCount += 1
				Else
					Exit For
				End If
			Next i
			If mergCount = 0 Then
				container.Margin = New Thickness(0, 0, 0, 0)
				Return False
			Else
				Dim rowHeight As Integer = If(grid.IsGrouped, 20, 21)
				container.Margin = New Thickness(0, 0, 0, -rowHeight * mergCount)
				Return True
			End If
		End Function
	End Class
	Public Class NegativeConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			Return -CInt(Fix(value))
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Nothing
		End Function
	End Class
	Public Class MyStackVisibleIndexPanel
		Inherits StackVisibleIndexPanel
		Protected Overrides Function MeasureSortedChildrenOverride(ByVal availableSize As Size, ByVal sortedChildren As IList(Of UIElement)) As Size
			Dim origAvalSize As Size = availableSize
			Dim baseMeasureSize As Size = MyBase.MeasureSortedChildrenOverride(availableSize, sortedChildren)
			If origAvalSize.Width < baseMeasureSize.Width Then
				baseMeasureSize.Width = origAvalSize.Width
			End If
			Return baseMeasureSize
		End Function

	End Class
	Public Class Customer
		Public Property ID() As Integer
		Public Property Name() As String
	End Class
End Namespace
