<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CellMerging/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CellMerging/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CellMerging/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CellMerging/MainWindow.xaml.vb))
<!-- default file list end -->
# How to merge cells in the GridControl


<p>This example demonstrates how to merge cells in GridControl. Starting with version 14.2 GridControl supports CellMerging out of the box. To enable this feature, set TableView.AllowCellMerge to "True".<br /><br /><strong>For version 14.1 and older:</strong><br />The main idea consists of stretching the top merged cell and showing it over other merged cells. For this purpose, the Panel.ZIndex and Margin properties are used.</p>
<p>Please take special note that this example doesn't support editing cells. This example is designed for the DeepBlue theme and may need to be modified if you wish to use it in other themes.</p>

<br/>


