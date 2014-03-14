using Android.Content;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using CoffeeFinder.Android.Services;
using CoffeeFinder.Core.Services;

namespace CoffeeFinder.Android
{
    public class Setup : MvxAndroidSetup
    {
        private Context _appContext;

        public Setup(Context applicationContext) : base(applicationContext)
        {
            this._appContext = applicationContext;
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

            Mvx.RegisterSingleton<ILocationService>(() => new AndroidLocationService(this._appContext));
        }
    }
}