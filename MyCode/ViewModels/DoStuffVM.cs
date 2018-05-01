using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCode.ViewModels
{
    
    public class DoStuffVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<string> PetTypes { get; set; }

        private string _selectedPet;
        

        public string SelectedPet
        {
            get { return _selectedPet; }
            set {
                _selectedPet = value;
                if (PetTypes.Contains(_selectedPet) == false)
                {
                    PetTypes.Add(_selectedPet);
                }
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedPet)));
            }
        }


        public DoStuffVM()
        {
            //Thanks to https://liftcodeplay.com/2016/02/18/combobox-with-editable-textbox/

            PetTypes = new ObservableCollection<string>();

            PetTypes.Add("Cat");
            PetTypes.Add("Dog");
        }
    }
}
