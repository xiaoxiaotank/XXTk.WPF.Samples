using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XXTk.WPF.Samples.BindingSample.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDynamic_Click(object sender, RoutedEventArgs e)
        {
            var style = new Style { TargetType = typeof(Button) };
            style.Setters.Add(new Setter { Property = Button.FontSizeProperty, Value = (double)Random.Shared.Next(10, 30) });

            // 替换掉原来的资源
            Resources["SampleButtonStyle"] = style;
        }
    }
}