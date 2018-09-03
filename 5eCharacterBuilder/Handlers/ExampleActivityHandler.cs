using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _5eCharacterBuilder.Handlers;
using _5eCharacterBuilder.Utilities;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;

namespace _5eCharacterBuilder.Handlers
{
    public class ExampleActivityHandler : IHandler
    {
        private Activity _activity;
        public void AddContext(Activity activity)
        {
            _activity = activity;
        }

        public void RunContextBinding()
        {
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
    }
}