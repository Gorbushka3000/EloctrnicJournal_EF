using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EloctrnicJournal_EF.Model
{
    public class Rating : INotifyPropertyChanged
    {
        public DateTime date;
        public int lessonId;
        public int teacherId;
        public DateTime DateRating
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("DateRating");
            }
        }
        public Lesson Lesson { get; set; }
        public int LessonId
        {
            get { return lessonId; }
            set
            {
                lessonId = value;
                OnPropertyChanged("LessonId");
            }
        }
        public Teacher Teacher { get; set; }
        public int TeacherId
        {
            get { return teacherId; }
            set
            {
                teacherId = value;
                OnPropertyChanged("TeacherId");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

    public class Passes : Rating
    {
        public int Id { get; set; }
        public char pass;
        public int studentId;
        public Student Student { get; set; }
        public int StudentId
        {
            get { return studentId; }
            set
            {
                studentId = value;
                OnPropertyChanged("StudentId");
            }
        }
        public char Pass
        {
            get { return pass; }
            set 
            { 
                pass = value; 
                OnPropertyChanged("Pass");
            }
        }
    }

    public class Grade : Rating
    {
        public int Id { get; set; }
        public int grades;
        public string? comment;
        public int studentId;
        public List<Student> Students { get; set; }
        public int StudentId
        {
            get { return studentId; }
            set
            {
                studentId = value;
                OnPropertyChanged("StudentId");
            }
        }

        public int Grades
        {
            get { return grades; }
            set 
            {
                grades = value; 
                OnPropertyChanged("Grades");
            }
        }
        public string? Comment
        {
            get { return comment; }
            set
            {
                comment = value;
                OnPropertyChanged("Comment");
            }
        }
    }

    public class HomeWork : Rating
    {
        public int Id { get; set; }
        public string task;
        
    }
}

