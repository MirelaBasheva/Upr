using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _Name = "";
        string _FacNum = "";
        public string Name
        {
            get { return _Name; }
            set { PropertyChanged(this, new PropertyChangedEventArgs(Name)); }
        }

        public string FacNum
        {
            get { return _FacNum;}
            set { PropertyChanged(this, new PropertyChangedEventArgs(FacNum)); }
        }

        Command _BtnCommand = new Command();

        public Command BtnCommand
        {
            get { return _BtnCommand; }
        }
    }
}
