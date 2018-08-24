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
    public class ExampleActivity : BaseActivity
    {
        public ExampleActivity()
        {
            ViewModel = new CharacterMetaData();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //important stuff goes here I think.
        }

        public async override Task SaveAsync()
        {
            var db = App.Resolve<IDbContext>();
            await db.SaveItemAsync(ViewModel as CharacterMetaData);
            return;
        }
    }
}