using EloctrnicJournal_EF.Data;
using System.ComponentModel;
using EloctrnicJournal_EF.Model;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using EloctrnicJournal_EF.View;
using System;
using System.Windows;

namespace EloctrnicJournal_EF.ViewModel
{
    internal class ElectronicJournalViewModel : INotifyPropertyChanged
    {
        EJContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deleteCommand;
        RelayCommand wow;
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
                        StudentChangeWindow studentWindow = new StudentChangeWindow(new Student());
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
                            PhoneNumber = 5656,
                            Class = 1,
                            TeacherId = 1
                        };
                        StudentChangeWindow studentWindow = new StudentChangeWindow(vm);

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
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
