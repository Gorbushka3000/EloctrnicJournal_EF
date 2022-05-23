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
        public string? Password { get; set; }
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
                OnPropertyChanged("PhoneNumber");
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
        public int teacherid;
        public int classNumberId;
        public int Id { get; set; }
        public ClassNumber ClassNumber { get; set; }
        public int ClassNumberId
        {
            get { return classNumberId; }
            set
            {
                classNumberId = value;
                OnPropertyChanged("ClassNumberId");
            }
        }
        public Teacher Teacher { get; set; }
        public int TeacherId
        {
            get { return teacherid; }
            set
            { 
                teacherid = value;
                OnPropertyChanged("TeacherId");
            }
        }
        public List<Grade> Grades { get; set; }
        public List<Passes> Passes { get; set; }
    }
    public class Teacher : User
    {
        public int Id { get; set; }
        public List<Student> Student { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Passes> Pass { get; set; }
    }
}
