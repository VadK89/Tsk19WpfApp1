using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tsk19WpfApp1.Models;

namespace Tsk19WpfApp1.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private double rad;
        public double Rad
        {
            get => rad;
            set
            {
                rad = value;
                OnPropertyChanged();
            }
        }
        private double diam;
        public double Diam
        {
            get => diam;
            set
            {
                diam = value;
                OnPropertyChanged();
            }
        }
        private double length;
        public double Length
        {
            get => length;
            set
            {
                length = value;
                OnPropertyChanged();
            }
        }
        private double area;
        public double Area
        {
            get => area;
            set
            {
                area = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            //Number3 = Number1 + Number2;
            Diam = CircleCalc.DiaCalc(Rad);
            Length = CircleCalc.LenCalc(Rad);
            Area = CircleCalc.AreCalc(Rad);
        }
        private bool CanAddCommandExecuted(object p)
        {
            //return true;
            if (Rad != 0)
                return true;
            else
                return
                    false;
        }
        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
        }
    }
}
