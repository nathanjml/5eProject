using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5eCharacterBuilder.StandardCore.Helpers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace _5eCharacterBuilder
{
    [Activity(Label = "ClassActivity")]
    public class ClassActivity : BaseActivity
    {
        private readonly IMasterContext _masterContext;

        public ClassActivity()
        {
            _masterContext = App.Resolve<IMasterContext>();
        }
        public override Task SaveAsync()
        {
            return null;
        }
    }
}