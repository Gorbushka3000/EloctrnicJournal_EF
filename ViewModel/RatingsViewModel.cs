using EloctrnicJournal_EF.Data;
using EloctrnicJournal_EF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EloctrnicJournal_EF.ViewModel
{
    public class RatingsViewModel :INotifyPropertyChanged
    {
        EJContext db;
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
    }
}
