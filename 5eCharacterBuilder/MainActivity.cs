using System;
using System.Collections.Generic;
using System.IO;
using _5eCharacterBuilder.StandardCore.Configuration;
using _5eCharacterBuilder.StandardCore.Settings;
using _5eCharacterBuilder.Utilities;
using Android;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SimpleInjector;

namespace _5eCharacterBuilder
{
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    { 
        private bool IsInitialized = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            if(!IsInitialized)
            {
                Configure();
            }
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            //NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
           // navigationView.SetNavigationItemSelectedListener(this);

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

            var listView = FindViewById<ListView>(Resource.Id.CharacterListView);
            var adapter = new ListViewAdapter(this, _characters);
            listView.Adapter = adapter;
        }

        private void Configure()
        {
            var container = new Container();
            var settings = ConfigureAppSettings();
            container.ConfigureCore(settings);
            App.Initialize(container.GetInstance);

            container.Verify();
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            if (id == Resource.Id.nav_camera)
            {
                // Handle the camera action
            }
            else if (id == Resource.Id.nav_gallery)
            {

            }
            else if (id == Resource.Id.nav_slideshow)
            {

            }
            else if (id == Resource.Id.nav_manage)
            {

            }
            else if (id == Resource.Id.nav_share)
            {

            }
            else if (id == Resource.Id.nav_send)
            {

            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
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

