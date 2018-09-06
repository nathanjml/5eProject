﻿using System;
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
    public interface IHandler
    {
        void AddContext(BaseActivity activity);
        void RunContextBinding();
    }
}