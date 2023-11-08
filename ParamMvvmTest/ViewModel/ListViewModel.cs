using ParamMvvmTest.Model;
using ParamMvvmTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamMvvmTest.ViewModel
{
    public class ListViewModel : ViewModelBase
    {
        private readonly MainViewModel _vm;
        private readonly Person _person;

        public string Id => _person.Id.ToString();
        public string Name => _person.Name;


        public ListViewModel(Person person)
        {
            _person = person;
        }

        public void Upd()
        {
            OnPropertyChanged(nameof(Id));
            OnPropertyChanged(nameof(Name));
        }
    }
}
