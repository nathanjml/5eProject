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
using _5eCharacterBuilder.StandardCore.Helpers;
using _5eCharacterBuilder.StandardCore.Features;
using _5eCharacterBuilder.Configuration;

namespace _5eCharacterBuilder.Handlers
{
    public class ExampleActivityHandler : IHandler
    {
        private BaseActivity _activity;
        private bool IsInitialized = false;
        private IDbContext _dbContext;
        private IMasterContext _masterContext;
        private ListView listView;
        private ListViewAdapter adapter;
        private List<ViewModels.Character> characters;

        public void AddContext(BaseActivity activity)
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
            _dbContext = App.Resolve<IDbContext>();
            _masterContext = App.Resolve<IMasterContext>();

            _activity.SetContentView(Resource.Layout.activity_main);

            characters = new List<ViewModels.Character>();
            characters.Add(new ViewModels.Character()
            {
                Id = 0,
                Name = "Stevie Rogue",
                PlayerName = "Steve D. Mann"
            });
            characters.Add(new ViewModels.Character()
            {
                Id = 0,
                Name = "Amasha Vren, legend of the citidel",
                PlayerName = "Carly Sue"
            });

            FloatingActionButton fab = _activity.FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            listView = _activity.FindViewById<ListView>(Resource.Id.CharacterListView);
            adapter = new ListViewAdapter(_activity, characters);
            listView.Adapter = adapter;

            listView.ItemClick += ListView_ItemClick;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var item = adapter[e.Position];
            _masterContext.DataReferenceId = item.Id;
            //Start up a new activity
            _activity.StartActivity(typeof(ClassActivity));
        }

        private async void FabOnClick(object sender, EventArgs eventArgs)
        {
            var character = new ViewModels.Character()
            {
                Name = "New Character",
                PlayerName = "Mom",
            };

            var entity = new CharacterMetaData(); 

            entity.CharacterName = character.Name;
            entity.PlayerName = character.PlayerName;

            await _dbContext.SaveItemAsync(entity);
            character.Id = entity.Id;

            characters.Add(character);
            adapter.NotifyDataSetChanged();
            
        }

        private void Configure()
        {
            var container = new Container();
            var settings = ConfigureAppSettings();
            container.ConfigureCore(settings);
            container.ConfigureXamarin();
            App.Initialize(container.GetInstance);

            ModelBuilder b = new ModelBuilder(App.Resolve<IDbContext>());
            b.FromAssemblies(typeof(ModelBuilder).Assembly);
            b.Build();

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