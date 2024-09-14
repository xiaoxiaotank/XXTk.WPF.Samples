using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XXTk.WPF.Samples.BindingSample.App;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _name = "xiaoxiaotank";

    [RelayCommand]
    private void ShowAppRuntimeInfoUserName() => MessageBox.Show($"AppRuntimeInfo.UserName: {AppRuntimeInfo.UserName}");

    [RelayCommand]
    private void NewAppVersion() => AppRuntimeInfo.AppVersion = new AppVersion() { Version = $"{DateTime.Now.Millisecond}.0.0.0" };

    [RelayCommand]
    private void ChangeAppVersion() => AppRuntimeInfo.AppVersion.Version = $"{DateTime.Now.Millisecond}.0.0.0";
}
