using EloctrnicJournal_EF.Data;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using EloctrnicJournal_EF.View;
using EloctrnicJournal_EF.Model;

namespace EloctrnicJournal_EF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EJContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new EJContext();
            db.Student.Load();
            this.DataContext = db.Student.Local.ToBindingList();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            StudentWindow studentWindow = new StudentWindow(new Student());
            if (studentWindow.ShowDialog() == true)
            {
                Student student = studentWindow.Student;
                db.Student.Add(student);
                db.SaveChanges();
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (studentList.SelectedItem == null) return;
            Student student = studentList.SelectedItem as Student;
            StudentWindow studentWindow = new StudentWindow(new Student
            {
                Id = student.Id,
                Name = student.Name,
                LastName = student.LastName,
                Email = student.Email,
                PhoneNumber = student.PhoneNumber,
                Class = student.Class,
                ParentId = student.ParentId,
                TeacherId = student.TeacherId
            });
            if (studentWindow.ShowDialog() == true)
            {
                student = db.Student.Find(studentWindow.Student.Id);
                if(student != null)
                {
                    student.Name = studentWindow.Student.Name;
                    student.LastName = studentWindow.Student.LastName;
                    student.Email = studentWindow.Student.Email;
                    db.Entry(student).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (studentList.SelectedItem == null) return;
            Student student = studentList.SelectedItem as Student;
            db.Student.Remove(student);
            db.SaveChanges();
        }
    }
}

