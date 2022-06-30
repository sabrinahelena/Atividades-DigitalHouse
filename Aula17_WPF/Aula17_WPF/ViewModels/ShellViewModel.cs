using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Aula17_WPF.Models;

namespace Aula17_WPF.ViewModels
{
    public class ShellViewModel : Screen
    {

        private string _firstName = "Sabrina";
        private string _lastName;
        private string _fullName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>(); //tipo lista
        private PersonModel _selectedPerson;
        public ShellViewModel() //Simular banco de dados 
        {
            People.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            People.Add(new PersonModel { FirstName = "Sabrina", LastName = "Helena" });
            People.Add(new PersonModel { FirstName = "Caroline", LastName = "Ferreira" });

        }




        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName); //avisa se for trocada, isso att a propriedade
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set 
            { 
                _lastName = value; 
                NotifyOfPropertyChange(() => LastName); 
                NotifyOfPropertyChange(() => FullName); 
            }
        }


        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
      
        }


        public BindableCollection<PersonModel> People //lista
        {
            get { return _people; }
            set { _people =value; }
        }




        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearText(string firstName, string lastName)
        {
            if(String.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }

       
    }
}
