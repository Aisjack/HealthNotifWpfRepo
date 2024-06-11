using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthNotificationWpf
{
    public class eventsNotify : INotifyPropertyChanged
    {
        private int _opacityValue;
        public int OpacityValue 
        { 
            get => _opacityValue; 
            set
            {
                _opacityValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OpacityValue)));
            } 
        }

        private int _heightValue;
        public int HeightValue 
        { 
            get => _heightValue; 
            set
            {
                _heightValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HeightValue)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
