<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128651967/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4614)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/WpfApplication88/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/WpfApplication88/MainWindow.xaml.vb))**
* [MainWindow.xaml.cs](./CS/WpfApplication88/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication88/MainWindow.xaml.vb))
<!-- default file list end -->
# How to merge cells in the GridControl


<p>This example demonstrates how to merge cells in GridControl. Starting with version 14.2 GridControl supports CellMerging out of the box. To enable this feature, set TableView.AllowCellMerge to "True".<br /><br /><strong>For version 14.1 and older:</strong><br />The main idea consists of stretching the top merged cell and showing it over other merged cells. For this purpose, the Panel.ZIndex and Margin properties are used.</p>
<p>Please take special note that this example doesn't support editing cells. This example is designed for the DeepBlue theme and may need to be modified if you wish to use it in other themes.</p>

<br/>


