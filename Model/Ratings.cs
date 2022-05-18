
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EloctrnicJournal_EF.Model
{
    public class Ratings : INotifyPropertyChanged
    {
        public int rating;
        public DateTime date;
        public int lessonId;
        public int teacherId;
        public string? comment;
        public int studentId;

        public int Id { get; set; }
        public int Rating
        {
            get { return rating; }
            set 
            {
                rating = value;
                OnPropertyChanged("Rating");
            }
        }
        public DateTime DateRating
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("DateRating");
            }
        }
        public int LessonId
        {
            get { return lessonId; }
            set
            {
                lessonId = value;
                OnPropertyChanged("LessonId");
            }
        }
        public int TeacherId
        {
            get { return teacherId; }
            set
            {
                teacherId = value;
                OnPropertyChanged("TeacherId");
            }
        }

        public string Comment
        {
            get { return comment; }
            set
            {
                comment = value;
                OnPropertyChanged("Comment");
            }
        }

        public int StudentId
        {
            get { return studentId; }
            set
            {
                studentId = value;
                OnPropertyChanged("StudentId");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

    public class Passes : INotifyPropertyChanged
    {
        public char pass;
        public int lessonId;
        public int teacherId;
        public DateTime date;
        public int studentId;

        public int Id { get; set; }
        public char Pass
        {
            get { return pass; }
            set { 
                pass = value;
                OnPropertyChanged("Pass");
            }
        }
        public int LessonId
        {
            get { return lessonId; }
            set
            {
                lessonId = value;
                OnPropertyChanged("LessonId");
            }
        }
        public int StudenId
        {
            get { return studentId; }
            set
            {
                studentId = value;
                OnPropertyChanged("StudentId");
            }

        }
        public DateTime DatePass
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("DatePass");
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

