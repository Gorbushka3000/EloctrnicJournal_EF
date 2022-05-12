using EloctrnicJournal_EF.Data;
using System.ComponentModel;
using EloctrnicJournal_EF.Model;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using EloctrnicJournal_EF.View;

namespace EloctrnicJournal_EF.ViewModel
{
    internal class ElectronicJournalViewModel : INotifyPropertyChanged
    {
        EJContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deleteCommand;
        IEnumerable<Student> students;

        public IEnumerable<Student> Students
        {
            get { return students; }
            set 
            { 
                students = value;
                OnPropertyChanged("Students");
            }
        }
        public ElectronicJournalViewModel()
        {
            db = new EJContext();
            db.Student.Load();
            Students = db.Student.Local.ToBindingList();
        }
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand((o) =>
                    {
                        StudentWindow studentWindow = new StudentWindow(new Student());
                        if (studentWindow.ShowDialog() == true)
                        {
                            Student student = studentWindow.Student;
                            db.Student.Add(student);
                            db.SaveChanges();
                        }
                    }));
            }
        }
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                    (editCommand = new RelayCommand((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        Student student = selectedItem as Student;

                        Student vm = new Student()
                        {
                            Id = student.Id,
                            Name = student.Name,
                            LastName = student.LastName,
                            Email = student.Email,
                            PhoneNumber = student.PhoneNumber,
                            Class = student.Class,
                            ParentId = student.ParentId,
                            TeacherId = student.TeacherId
                        };
                        StudentWindow studentWindow = new StudentWindow(vm);

                        if (studentWindow.ShowDialog() == true)
                        {
                            student = db.Student.Find(studentWindow.Student.Id);
                            if (student != null)
                            {
                                student.Name = studentWindow.Student.Name;
                                student.LastName = studentWindow.Student.LastName;
                                student.Email = studentWindow.Student.Email;
                                student.PhoneNumber = 54545;
                                db.Entry(student).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                    }));
            }
        }
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                    (deleteCommand = new RelayCommand((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        Student student = selectedItem as Student;
                        db.Student.Remove(student);
                        db.SaveChanges();
                    }));
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
