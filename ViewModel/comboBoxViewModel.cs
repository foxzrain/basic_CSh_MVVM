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
    public class comboBoxViewModel : INotifyPropertyChanged
    {
        public comboBoxViewModel()
        {
            CBModel.Add(new cbModel() { Value = "A" }); 
            CBModel.Add(new cbModel() { Value = "B" });

            ModelSelectedItem = Categories.First().Value;
        }

        // data in combobox 
        public ObservableCollection<cbModel> CBModel = new ObservableCollection<cbModel>();

        public ObservableCollection<cbModel> Categories
        {
            get
            {
                return CBModel;
            }
            set
            {
                CBModel = value;
                OnPropertyChanged("Categories");
            }
        }

        // selected item
        private cbModel modelSelectedItem = new cbModel();

        public string ModelSelectedItem
        {
            get { return modelSelectedItem.Value; }
            set
            {
                modelSelectedItem.Value = value;
                OnPropertyChanged("ModelSelectedItem");
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
