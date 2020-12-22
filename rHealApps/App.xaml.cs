using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rHealApps
{
    /// <summary>
    /// The Application Startup calss
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // the method that provides default
            // initialization settings for the application
            // Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(App));
            // 1. Loads the XAML file in this case App.xaml
            // 2. Parse the File
            // 3. Map the XAML tags (?) from file to correcponding .NET Types
            // 4. Compile them
            // 5. Execute them
            InitializeComponent();

            // represent the page to be loaded
            // when the App s loaded
            MainPage = new MainPage();
           
        }


        // Operations to be performed when device boots the appication
        // Start the app for the first time
        protected override void OnStart()
        {
        }

        // the app is put at lower index in Application Stack
        // the app enters in sleep mode
        protected override void OnSleep()
        {
        }
        // When the App resumes from sleep mode
        protected override void OnResume()
        {
        }
    }
}
