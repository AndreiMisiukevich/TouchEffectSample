
using System.Windows.Input;
using Xamarin.Forms;

namespace TouchEffectSample
{
    public partial class TapGesturePage
    {
        int count;
        ICommand increaseCommand;

        public TapGesturePage()
        {
            InitializeComponent();
        }

        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }

        public ICommand IncreaseCommand => increaseCommand ??= new Command(() => Count++);
    }
}
