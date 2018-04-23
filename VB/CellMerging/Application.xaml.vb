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
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows

Namespace CellMerging
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
	End Class
End Namespace
