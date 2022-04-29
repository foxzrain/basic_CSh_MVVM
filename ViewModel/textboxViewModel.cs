using basic_mvvm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_mvvm.ViewModel
{
    // constructor
    public class textboxViewModel
    {
        // call loadData when viewmodel create
        public textboxViewModel()
        {
            LoadData();
        }

        // import ObservableCollection<your_model> from System.Collections.ObjectModel
        public ObservableCollection<tbModel> TBModel
        {
            get;
            set;
        }

        public void LoadData()
        {
            // create new model
            ObservableCollection<tbModel> models = new ObservableCollection<tbModel>();

            models.Add(new tbModel { TBName = "Name 1" });
            models.Add(new tbModel { TBName = "Name 2" });

            TBModel = models;
        }
    }
}
