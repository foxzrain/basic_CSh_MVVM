using basic_mvvm.ViewModel;
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

namespace basic_mvvm.Views
{
    /// <summary>
    /// Interaction logic for tabControlView.xaml
    /// </summary>
    public partial class tabControlView : UserControl
    {
        public tabControlView()
        {
            InitializeComponent();

            this.DataContext = new sliderViewModel();
        }
    }
}
