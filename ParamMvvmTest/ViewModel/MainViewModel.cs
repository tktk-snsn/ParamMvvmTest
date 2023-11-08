using ParamMvvmTest.Model;
using ParamMvvmTest.Utils;
using ParamMvvmTest.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamMvvmTest.ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        private Person _person;
        public Person PersonA
        {
            get => _person;
            set
            {
                _person = value;
                OnPropertyChanged();
            }
        }


        public InputViewModel InputVM { get; }
        public ListViewModel ListVM { get; }

        public MainViewModel()
        {
            _person = new Person(1, "trdk");

            InputVM = new InputViewModel(PersonA);
            ListVM = new ListViewModel(PersonA);

            InputVM.PropertyChanged += InputVM_PropertyChanged;
        }

        private void InputVM_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(nameof(PersonA));
            ListVM.Upd();
        }
    }
}
