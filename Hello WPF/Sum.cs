using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Hello_WPF
{
    public class Sum : INotifyPropertyChanged
    {
        private string num1; 
        private string num2;
        private string result;

        public string Num1
        {
            get { return num1; }

            set
            {
                if (int.TryParse(value, out int number))
                {
                    num1 = value;
                    OnPropertyChanged("Num1");
                    OnPropertyChanged("Result");
                }
            }
        }

        public string Num2
        {
            get { return num2; }

            set
            {
                if (int.TryParse(value, out int number))
                {
                    num2 = value;
                    OnPropertyChanged("Num2");
                    OnPropertyChanged("Result");
                }
            }
        }

        public string Result 
        { 
            get { return (int.Parse(num1) + int.Parse(num2)).ToString(); } 

            set 
            { 
                result = (int.Parse(num1) + int.Parse(num2)).ToString();
                OnPropertyChanged("Result");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
