using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWPF.View_Model
{
    class ViewModelBase:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler/*デリゲート型*/ PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));　//イベントの発生
        }
    }
}
