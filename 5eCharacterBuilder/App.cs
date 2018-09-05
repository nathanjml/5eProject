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
using _5eCharacterBuilder.StandardCore.Helpers;

namespace _5eCharacterBuilder
{
    public static class App
    {

        public static Func<Type, object> GetInstance { get; private set; }
        public static IMasterContext _MasterContext { get; private set; }
        public static void Initialize(Func<Type, object> getInstance)
        {
            GetInstance = getInstance;
            _MasterContext = Resolve<IMasterContext>();

        }

        public static T Resolve<T>()
        {
            return (T) GetInstance.Invoke(typeof(T));
        }
    }
}