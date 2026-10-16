using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace baiso1
{
    public class Device : INotifyPropertyChanged
    {
        private string _deviceId;
        private string _deviceName;
        private string _category;
        private decimal _price;
        private int _quantity;

        public string DeviceId
        {
            get => _deviceId;
            set { _deviceId = value; OnPropertyChanged(); }
        }

        public string DeviceName
        {
            get => _deviceName;
            set { _deviceName = value; OnPropertyChanged(); }
        }

        public string Category
        {
            get => _category;
            set { _category = value; OnPropertyChanged(); }
        }

        public decimal Price
        {
            get => _price;
            set { _price = value; OnPropertyChanged(); }
        }

        public int Quantity
        {
            get => _quantity;
            set { _quantity = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}