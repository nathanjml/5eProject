using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5eCharacterBuilder.StandardCore.Data;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace _5eCharacterBuilder
{
    public abstract class BaseActivity : AppCompatActivity
    {
        protected IEntity ViewModel { get; set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnBackPressed()
        {
            SaveAsync();
            base.OnBackPressed();
        }

        public abstract Task SaveAsync();
    }
}