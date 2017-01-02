using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace N2KittensView.Droid.Views
{
    [Activity(Label = "Kitten Listview")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
