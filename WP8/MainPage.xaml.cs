using Microsoft.Phone.Controls;
using PortableLib;

namespace WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            var are = new PortableReactiveObject();
        }
    }
}