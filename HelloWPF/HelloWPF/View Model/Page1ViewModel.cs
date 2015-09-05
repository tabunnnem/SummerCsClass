using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using HelloWPF.Annotations;
using HelloWPF.Common;
using HelloWPF.View;

namespace HelloWPF.View_Model
{
    class Page1ViewModel : ViewModelBase
    {
        private string _text1;


        public string Text1
        {
            get { return _text1; }
            set
            {
                _text1 = value; 
                OnPropertyChanged("Text1");
            }
        }

        public ICommand ClickedCommand{ get; set; }

        
        public Page1ViewModel(string text)
        {
            Text1 = text;
        }
        public ICommand Clickedplusgmail { get; set; }
        public Page1ViewModel()
        {
            ClickedCommand = new SimpleCommand(o =>
            {
                ((NavigationWindow)Application.Current.MainWindow).Navigate(new Page2(){DataContext = this});
            });

            Clickedplusgmail = new SimpleCommand(o =>
            {
                Text1 += "@gmai.com";
            });
        }


        
    }
}
