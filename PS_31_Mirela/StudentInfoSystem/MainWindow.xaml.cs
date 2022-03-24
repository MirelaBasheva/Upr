using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {
            foreach (var item in StudentInfoSystem.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        public void GetStudentInfo(int index)
        {
            List<Student> students = StudentData.TestStudents;

            txtName.Text = students[index].name;
            txtMiddleName.Text = students[index].middleName;
            txtFamilyName.Text = students[index].familyName;
            txtFaculty.Text = students[index].faculty;
            txtSpecialty.Text = students[index].specialty;
            txtEducationalDegree.Text = students[index].educationalDegree;
            txtStatus.Text = students[index].status;
            txtFacultyNumber.Text = students[index].facultyNumber;
            txtCourse.Text = students[index].course.ToString();
            txtFlow.Text = students[index].stream.ToString();
            txtGroup.Text = students[index].group.ToString();

        }

        public void DisableFields()
        {
            foreach (var cntrl in StudentInfoSystem.Children)
            {
                if (cntrl is TextBox)
                {
                    ((TextBox)cntrl).IsEnabled = false;
                }
            }
        }

        public void EnableFields()
        {
            foreach (var cntrl in StudentInfoSystem.Children)
            {
                if (cntrl is TextBox)
                {
                    ((TextBox)cntrl).IsEnabled = true;
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void btnDisableCntrls_Click(object sender, RoutedEventArgs e)
        {
            DisableFields();
        }

        private void btnShowData_Click(object sender, RoutedEventArgs e)
        {
            GetStudentInfo(counter);
        }

        private void btnEnableCntrls_Click(object sender, RoutedEventArgs e)
        {
            EnableFields();
        }

      
        private void showData_Click(object sender, RoutedEventArgs e)
        {
            txtText.Visibility = Visibility.Visible;
            if (counter > 2)
            {
                counter = 0;
            }
            GetStudentInfo(counter);
            counter++;
        }
    }
}
