using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt_ST
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        ObservableCollection<Student> ListaStudentow;
        public ListWindow()
        {
            InitializeComponent();
             ListaStudentow = new ObservableCollection<Student>
            {
                new Student(1, 1, "Adam", "Kowal", "123456789", 'm', "Wesola", "345", "Rzeszow"),
                new Student(1, 1, "Jan", "Kowalski", "123456789", 'm', "Mickiewicza", "123", "Rzeszow"),
            };
            txtTest.Text = ListaStudentow[0].phone.ToString();
            oknoListaStudentow.ItemsSource = ListaStudentow;
        }

        private void FiltrButton_Click(object sender, RoutedEventArgs e)
        {
           // ObservableCollection<Student> FiltrLista = new ObservableCollection<Student>
        }
    }
}
