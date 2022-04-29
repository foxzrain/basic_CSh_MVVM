using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_mvvm.Model
{
    // constructor
    public class textboxModel
    {
    }

    // import INotifyPropertyChanged from System.ComponentModel
    // create an object name tbModel
    public class tbModel : INotifyPropertyChanged
    {
        private string? _tbName;

        // function get-set for tbModel parameter
        public string TBName
        {
            get { return _tbName; }
            set { _tbName = value;
                // textbox input change notify
                RaisePropertyChanged("TBName");
            }
        }

        // MUST HAVE 
        // event interface
        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
