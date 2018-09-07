using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public void AddContext(BaseActivity activity)
        {
            _activity = activity;
        }

        public void RunContextBinding()
        {
            _activity.SetContentView(Resource.Layout.ClassActivityView);
        }
    }
}