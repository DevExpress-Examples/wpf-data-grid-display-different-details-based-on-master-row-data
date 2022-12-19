<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653562/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590724)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - Display Different Details Based on Data in the Master Row

This example displays different details for different master rows. Use the [DetailDescriptorSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorSelector) to display details based on the master row's content. Assign the default detail descriptor to the [DetailDescriptorSelector.DefaultValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorSelector.DefaultValue) property and use [DetailDescriptorTriggers](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorTrigger) to conditionally swith it to an another detail. This trigger has the [Binding](https://docs.devexpress.com/WPF/DevExpress.Xpf.DXBinding.DXTriggerBase.Binding) and [Value](https://docs.devexpress.com/WPF/DevExpress.Xpf.DXBinding.DXTriggerBase.Value) properties which work similarly to corresponding properties in a standard WPF [DataTrigger](https://learn.microsoft.com/en-us/dotnet/api/system.windows.datatrigger).

![image](https://user-images.githubusercontent.com/65009440/208456967-be612ce5-5aa0-4989-8b93-8c64d29fc85d.png)

## Files to Review

* [MainWindow.xaml](./CS/WpfApp30/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApp30/MainWindow.xaml))
* [ViewModel.cs](./CS/WpfApp30/ViewModel.cs) (VB: [ViewModel.vb](./VB/WpfApp30/ViewModel.vb))

## Documentation

* [Data Dependent Details](https://docs.devexpress.com/WPF/119850/controls-and-libraries/data-grid/master-detail/data-dependent-details)
* [DetailDescriptorSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorSelector)
* [DetailDescriptorSelector.DefaultValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorSelector.DefaultValue)
* [DetailDescriptorTrigger](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DetailDescriptorTrigger)

## More Examples

* [WPF Data Grid - Create Master-Detail Grid](https://github.com/DevExpress-Examples/wpf-data-grid-create-master-detail-grid)
* [WPF Data Grid - Create a Master-Detail Grid in Code](https://github.com/DevExpress-Examples/wpf-data-grid-create-master-detail-grid-in-code)
* [WPF Data Grid - Display Detail Content in Tabs](https://github.com/DevExpress-Examples/wpf-data-grid-display-detail-content-in-tabs)
* [WPF Data Grid - Expand and Collapse Master Rows](https://github.com/DevExpress-Examples/expanding-and-collapsing-master-rows-e4044)
* [WPF Data Grid - Specify Detail Buttons Visibility](https://github.com/DevExpress-Examples/detail-buttons-visibility-e4050)
