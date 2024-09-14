using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace XXTk.WPF.Samples.BindingSample.App
{
    public static class AppRuntimeInfo
    {
        public static event PropertyChangedEventHandler StaticPropertyChanged;

        private static string _userName = "xiaoxiaotank";
        public static string UserName
        {
            get => _userName;
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    RaiseStaticPropertyChanged(nameof(UserName));
                }
            }
        }

        private static AppVersion _appVersion = new() { Version = "1.0.0.0" };
        public static AppVersion AppVersion 
        {
            get => _appVersion;
            set
            {
                if (_appVersion != value)
                {
                    _appVersion = value;
                    RaiseStaticPropertyChanged(nameof(AppVersion));
                }
            }
        }

        private static void RaiseStaticPropertyChanged(string propertyName)
        {
            // 不推荐静态类中包含变更通知的属性，如果可以的话，建议改成单例
            // WPF框架会自动订阅 PropertyChangedEventHandler StaticPropertyChanged，类型和名字都必须是这个，不能改变
            // 更多请参考：https://github.com/dotnet/wpf/blob/main/src/Microsoft.DotNet.Wpf/src/PresentationFramework/MS/Internal/Data/StaticPropertyChangedEventManager.cs
            StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));
        }

        public static class MyBrushes
        {
            public static Brush HalfRed { get; set; } = new SolidColorBrush(Colors.Red) { Opacity = 0.5 };
        }

        public enum Gender
        {
            Female,
            Male
        }
    }


    public partial class AppVersion : ObservableObject
    {
        [ObservableProperty]
        private string _version;
    }
}
