using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using _5eCharacterBuilder.StandardCore.Data;
using _5eCharacterBuilder.StandardCore.Helpers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace _5eCharacterBuilder.Handlers
{
    public class ClassActivityHandler : IHandler
    {
        private BaseActivity _activity;
        private bool IsInitialized = false;
        private IDbContext _dbContext;
        private IMasterContext _masterContext;
        private NumberPicker picker;


        Dictionary<string, Color> backgroundpicker = new Dictionary<string, Color>{
                {"Sage", Color.Black},           {"Acolyte", Color.Black},
                {"Hermit", Color.Black},         {"Guild Artisan", Color.Black},
                {"Criminal", Color.Black},       {"Entertainer", Color.Black},
                {"Noble", Color.Black},          {"Fold Hero", Color.Black},
                {"Outlander", Color.Black},      {"Gladiator", Color.Black},
                {"Knight", Color.Black},         {"Charlatan", Color.Black},

            };

        public void AddContext(BaseActivity activity)
        {
            _activity = activity;
        }

        public void RunContextBinding()
        {
            _activity.SetContentView(Resource.Layout.ClassActivityView);

            if (!IsInitialized)
            {
                IsInitialized = true;
            }
            _dbContext = App.Resolve<IDbContext>();
            _masterContext = App.Resolve<IMasterContext>();

            _activity.SetContentView(Resource.Layout.activity_main);

            BackgroundPickerPage();

        }

        private void BackgroundPickerPage()
        {
            //Attempting to create a NumberPicker(this started as something different) to select from a list of backgrounds. Currently data will be 
            //defined here only, but eventually will need to connect to db.
            //Reference is being adapted from https://developer.xamarin.com/api/type/Android.Widget.NumberPicker/
            string[] pickerdisplay = new string[12];
            for (int i = 0; i > 12; i++)
            {
                pickerdisplay[i] = $"{i}";
            }
            picker.SetDisplayedValues(pickerdisplay);
            
            
        }
    }
}