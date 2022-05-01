using basic_mvvm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_mvvm.ViewModel
{
    public class sliderViewModel : INotifyPropertyChanged
    {
        public sliderViewModel()
        {
            SlideValue = 0;
        }

        public ObservableCollection<slideModel> SlideModel = new ObservableCollection<slideModel>();

        public ObservableCollection<slideModel> SlideValueModel
        {
            get { return SlideModel; }
            set 
            { 
                SlideModel = value;
                OnPropertyChanged("SV");
            }   
        }

        private slideModel slideValue = new slideModel();

        public double SlideValue
        {
            get { return slideValue.SValue; }
            set
            {
                slideValue.SValue = value;
                OnPropertyChanged("SlideValue");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }
    }
}
