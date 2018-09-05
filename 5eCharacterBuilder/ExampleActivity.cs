using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5eCharacterBuilder.StandardCore.Data;
using _5eCharacterBuilder.StandardCore.Features;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace _5eCharacterBuilder
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class ExampleActivity : BaseActivity
    {

        public ExampleActivity()
        {
            ViewModel = new CharacterMetaData();
        }

        public override async Task SaveAsync()
        {
            var db = App.Resolve<IDbContext>();
            await db.SaveItemAsync(ViewModel as CharacterMetaData);
        }


    }
}