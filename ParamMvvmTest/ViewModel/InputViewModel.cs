using ParamMvvmTest.Model;
using ParamMvvmTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamMvvmTest.ViewModel
{
    public class InputViewModel: ViewModelBase
    {
        private readonly Person _person;

        public int Id
        {
            get => _person.Id;
            set
            {
                _person.Id = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => _person.Name;
            set
            {
                _person.Name = value;
                OnPropertyChanged();
            }
        }


        public InputViewModel(Person person)
        {
            _person = person;
        }
    }
}
