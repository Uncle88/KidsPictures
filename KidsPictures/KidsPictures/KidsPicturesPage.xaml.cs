using System.Threading.Tasks;
using Xamarin.Forms;

namespace KidsPictures
{
    public partial class KidsPicturesPage : CarouselPage
    {
        public KidsPicturesPage()
        {
            InitializeComponent();
            ItemsSource = CollectionItems.All;
        }
    }
}
