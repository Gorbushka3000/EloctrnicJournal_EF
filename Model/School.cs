using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EloctrnicJournal_EF.Model
{
    public class School : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class Lesson : School
    {
        public string? lessonName;
        public int id { get; set; }
        public string? LessonName
        {
            get { return lessonName; }
            set 
            { 
                lessonName = value; 
                OnPropertyChanged("LessonName");
            }
        }
    }
    public class ClassNumber : School
    {
        public int Id { get; set; }
        public int classNumbers;
        public int ClassNumbers
        {
            get { return classNumbers; }
            set 
            {
                classNumbers = value;
                OnPropertyChanged("ClassNumbers");
            }
        }
    }

}
