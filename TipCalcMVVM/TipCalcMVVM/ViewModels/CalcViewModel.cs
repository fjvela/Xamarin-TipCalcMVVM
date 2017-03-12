using System.Windows.Input;
using Xamarin.Forms;

namespace TipCalcMVVM.ViewModels
{
    public class CalcViewModel : BindableObject
    {
        private decimal subTotal;
        private decimal tip;
        private decimal tipValue;
        private decimal total;
        private decimal totalAfterTax;

        public CalcViewModel()
        {
        }

        public ICommand CalculateTipCommand { get { return new Command(CalculateTip); } }
        public decimal SubTotal
        {
            get { return subTotal; }
            set
            {
                subTotal = value;
                OnPropertyChanged();
            }
        }

        public decimal Tip
        {
            get { return tip; }
            set
            {
                tip = value;
                OnPropertyChanged();
            }
        }

        

        public decimal TipValue
        {
            get { return tipValue; }
            set { tipValue = value; OnPropertyChanged(); }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; OnPropertyChanged(); }
        }

        public decimal TotalAfterTax
        {
            get { return totalAfterTax; }
            set
            {
                totalAfterTax = value;
                OnPropertyChanged();
            }
        }

        private void CalculateTip()
        {
            TipValue = System.Math.Round((SubTotal * Tip) / 100, 2);
            Total = TotalAfterTax + TipValue;
        }

     
    }
}