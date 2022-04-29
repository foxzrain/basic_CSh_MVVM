using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_mvvm.Model
{
    public class comboBoxModel
    {
    }

    public class cbModel : INotifyPropertyChanged
    {
        private string _value;
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                CBRaisePropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void CBRaisePropertyChanged(string v)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }
    }
}
