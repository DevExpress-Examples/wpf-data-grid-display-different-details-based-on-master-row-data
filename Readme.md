<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApp30/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/WpfApp30/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/WpfApp30/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApp30/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/WpfApp30/ViewModel.cs) (VB: [ViewModel.vb](./VB/WpfApp30/ViewModel.vb))
<!-- default file list end -->
# How to use different details depending on data in GridControl's master row


<p>To choose different details for a master row in GridControl, use <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorSelector.class">DetailDescriptorSelector</a> with <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorTrigger.class">DetailDescriptorTriggers</a>. Each trigger has the Binding and Value properties which work similarly to corresponding properties in a standard WPF DataTrigger. When a trigger is activated, a corresponding detail descriptor is used.</p>

<br/>


