using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfoSystem
{
    public class Command : ICommand
    {

        public void Execute(object parameter)
        {
            string name1 = ((LoginViewModel)parameter).Name;
              string pass1 = ((LoginViewModel)parameter).FacNum;

            if (Validation(name1, pass1) == true)
            {
                MainWindow w1 = new MainWindow();
                w1.Show();
                w1.GetStudentInfo2(pass1);
                //w1.showData.Visibility = Visibility.Hidden;
                //w1.btnLogin.Visibility = Visibility.Hidden;
            }
        }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            private bool Validation(string name, string pass)
            {
            StudentData data = new StudentData();
            foreach (Student Student in StudentData.TestStudents)
            {
                if ((name == Student.name) && (pass == Student.facultyNumber))
                {
                    return true;
                }

            }
            return false;

            }
    }
 }

