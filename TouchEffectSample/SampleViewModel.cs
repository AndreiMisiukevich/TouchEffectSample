using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace TouchEffectSample
{
    public class SampleViewModel: ObservableObject
    {
        int count;
        ICommand increaseCommand;
        ICommand increaseByTenCommand;


        public int Count
        {
            get => count;
            set => SetProperty(ref count, value);
        }

        public ICommand IncreaseCommand => increaseCommand ??= new Command(() => Count++);

        public ICommand IncreaseByTenCommand => increaseByTenCommand ??= new Command(() => Count += 10);
    }
}
