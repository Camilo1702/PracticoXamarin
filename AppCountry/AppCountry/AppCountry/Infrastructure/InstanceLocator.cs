
namespace AppCountry.Infrastructure
{
    using AppCountry.ViewModel;
        public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
