using FirstFloor.ModernUI.App.ViewModels;
using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFloor.ModernUI.App
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : ModernWindow
    {
        public Login()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();

            this.btnLogin.Background= new SolidColorBrush(Color.FromRgb(23, 146, 223));
            this.btnCancel.Background = new SolidColorBrush(Color.FromRgb(239, 166, 38));
        }
    }
}
