<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653562/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590724)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApp30/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApp30/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApp30/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApp30/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/WpfApp30/ViewModel.cs) (VB: [ViewModel.vb](./VB/WpfApp30/ViewModel.vb))
<!-- default file list end -->
# How to use different details depending on data in GridControl's master row


<p>To choose different details for a master row in GridControl, use <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorSelector.class">DetailDescriptorSelector</a> with <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorTrigger.class">DetailDescriptorTriggers</a>. Each trigger has the Binding and Value properties which work similarly to corresponding properties in a standard WPF DataTrigger. When a trigger is activated, a corresponding detail descriptor is used.</p>

<br/>


