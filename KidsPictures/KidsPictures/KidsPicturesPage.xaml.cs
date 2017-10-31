using System.Threading.Tasks;
using Xamarin.Forms;

namespace KidsPictures
{
    public partial class KidsPicturesPage : ContentPage
    {
        private int _privateField;

        public KidsPicturesPage()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            ////await method without await keyword
            //var result = Method().GetAwaiter();
            //result.OnCompleted(() =>
            //{
            //    var str = "we finishe async work";
            //    _label.Text = str;
            //});

            await Method();
            var str = "we finishe async work";
            _label.Text = str;
            }

        protected virtual async Task Method()
        {
            _privateField = 10;
            await Task.Run(async () =>
            {
                _label.Text = "her tobi";
                await Task.Delay(3000);
                Device.BeginInvokeOnMainThread(() =>
                {
                    _label.Text = "jooo";
                });
                await Task.Delay(2000);
            });
        }

        private int NotAsyncMethod()
        {
            return 1;
        }
    }
}
