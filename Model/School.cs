using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


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
        public int classNumber;
        public int ClassNum
        {
            get { return classNumber; }
            set 
            {
                classNumber = value;
                OnPropertyChanged("ClassNum");
            }
        }
        public List<Student> Students { get; set; }
    }

}
