using System.Windows;
using EloctrnicJournal_EF.ViewModel;

namespace EloctrnicJournal_EF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ElectronicJournalViewModel();
        }
    }
}

