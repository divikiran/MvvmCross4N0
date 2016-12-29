using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace N1TipCalc.Droid.Views
{
    [Activity(Label = "Tip Calculator")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
