using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_mvvm.Model
{
    public class sliderModel
    {
    }

    public class slideModel : INotifyPropertyChanged
    {
        private double _sValue;

        public double SValue
        {
            get { return _sValue; }

            set 
            { 
                _sValue = value;
                SRaisePropertyChanged("SValue");

            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void SRaisePropertyChanged(string s)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(s));
            }
        }
    }
}
