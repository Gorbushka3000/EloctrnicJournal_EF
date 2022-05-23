using System.Windows;
using EloctrnicJournal_EF.ViewModel;
namespace EloctrnicJournal_EF.View
{
    public partial class RatingsStudentWindow : Window
    {
        public RatingsStudentWindow()
        {
            InitializeComponent();
            DataContext = new RatingsViewModel();
        }
    }
}
