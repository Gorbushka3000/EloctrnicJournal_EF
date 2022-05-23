using EloctrnicJournal_EF.Data;
using EloctrnicJournal_EF.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace EloctrnicJournal_EF.ViewModel
{
    public class RatingsViewModel :INotifyPropertyChanged
    {
        EJContext db;
        RelayCommand wow;
        public IEnumerable<Grade> grades;
        public IEnumerable<Grade> Grades
        {
            get { return grades; }
            set
            {
                grades = value;
                OnPropertyChanged("Grades");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public RelayCommand WoW
        {
            get
            {
                return wow ??
                    (wow = new RelayCommand((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        Student student = selectedItem as Student;
                        MessageBox.Show($"Ученик Имя: {student.Name}");
                    }));
            }
        }
    }
}
