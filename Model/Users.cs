using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace EloctrnicJournal_EF.Model
{
    public class User : INotifyPropertyChanged
    {
        public string? name;
        public string? lastname;
        public string? email;
        public int phonenumber;
        public string? password;
        public string? photo;

        public string? Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string? LastName
        {
            get { return lastname; }
            set 
            {
                lastname = value; OnPropertyChanged("LastName");
            }
        }
        public string? Email
        {
            get { return email; }
            set 
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }   
        public int PhoneNumber
        {
            get { return phonenumber; }
            set 
            {
                phonenumber = value; 
                OnPropertyChanged("phonenumber");
            }
        }

       // [Required]
       // public DateTime BirtDay { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

    public class Student : User
    {
        public int studentsclass;
        public int parentid;
        public int teacherid;
        public int Id { get; set; }
        public int Class
        {
            get { return studentsclass; }
            set 
            {
                studentsclass = value; 
                OnPropertyChanged("studentclass");
            }
        }
        public Parent Parent { get; set; }
        public int ParentId
        {
            get { return parentid; }
            set
            {
                parentid = value;
                OnPropertyChanged("parentid");
            }
        }
        public Teacher Teacher { get; set; }
        public int TeacherId
        {
            get { return teacherid; }
            set
            { 
                teacherid = value;
                OnPropertyChanged("teacherid");
            }
        }
    }
    public class Parent : User
    {
        public int Id { get; set; }
        public List<Student> Student { get; set; }
    }
    public class Teacher : User
    {
        public int Id { get; set; }
        public List<Student> Student { get; set; }
    }
}
