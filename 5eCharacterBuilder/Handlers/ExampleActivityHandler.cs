using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _5eCharacterBuilder.Handlers;
using _5eCharacterBuilder.StandardCore.Data;
using _5eCharacterBuilder.Utilities;
using _5eCharacterBuilder.StandardCore.Configuration;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using _5eCharacterBuilder.StandardCore.Settings;
using System.IO;
using SimpleInjector;

namespace _5eCharacterBuilder.Handlers
{
    public class ExampleActivityHandler : IHandler
    {
        private Activity _activity;
        private bool IsInitialized = false;

        public void AddContext(Activity activity)
        {
            _activity = activity;
        }


        public void RunContextBinding()
        {
            if (!IsInitialized)
            {
                Configure();
                IsInitialized = true;
            }

            _activity.SetContentView(Resource.Layout.activity_main);

            var _characters = new List<ViewModels.Character>();
            _characters.Add(new ViewModels.Character()
            {
                Name = "Stevie Rogue",
                PlayerName = "Steve D. Mann"
            });
            _characters.Add(new ViewModels.Character()
            {
                Name = "Amasha Vren, legend of the citidel",
                PlayerName = "Carly Sue"
            });

            FloatingActionButton fab = _activity.FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            var listView = _activity.FindViewById<ListView>(Resource.Id.CharacterListView);
            var adapter = new ListViewAdapter(_activity, _characters);
            listView.Adapter = adapter;
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with Create Character Option", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        private void Configure()
        {
            var container = new Container();
            var settings = ConfigureAppSettings();
            container.ConfigureCore(settings);
            App.Initialize(container.GetInstance);

            ModelBuilder b = new ModelBuilder();
            b.FromAssemblies(typeof(ModelBuilder).Assembly);


            container.Verify();
        }

        private AppSettings ConfigureAppSettings()
        {
            var settings = new AppSettings();
            settings.AppTitle = "5e Character Builder";
            settings.Version = "v0.1";
            settings.SupportEmail = "genericsupport@support.live";
            var app = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            settings.DbPath = Path.Combine(app, "5edata.db3");

            return settings;
        }
    }
}