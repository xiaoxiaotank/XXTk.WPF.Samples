using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace XXTk.WPF.Samples.BindingSample.App
{
    public static class AppRuntimeInfo
    {
        public static string UserName { get; set; } = "xiaoxiaotank";

        public static AppVersion AppVersion { get; set; } = new AppVersion { Version = "1.0.0.0" };

        public static class MyBrushes
        {
            public static Brush Red { get; set; } = Brushes.Red;
        }

        public enum Gender
        {
            Female,
            Male
        }
    }
    

    public class AppVersion
    {
        public string Version { get; set; }
    }
}
