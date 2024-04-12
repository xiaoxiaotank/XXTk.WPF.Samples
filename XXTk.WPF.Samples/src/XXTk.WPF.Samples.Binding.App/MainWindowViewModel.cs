using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XXTk.WPF.Samples.BindingSample.App;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _name = "xiaoxiaotank";
}
