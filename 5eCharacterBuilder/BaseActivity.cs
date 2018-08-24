using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using _5eCharacterBuilder.Handlers;

namespace _5eCharacterBuilder
{
    public abstract class BaseActivity : AppCompatActivity
    {
        protected IEntity ViewModel { get; set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            if (this.GetType().CustomAttributes.Any(x => x.AttributeType == typeof(NoHandle)))
            {
                //no handler associated.
                return;
            }

            var handler = FindHandlerByReflection();
            handler.AddContext(this);
            handler.RunContextBinding();
        }

        private IHandler FindHandlerByReflection()
        {
            var type = this.GetType().Name;
            var typeNamespace = this.GetType().Namespace;
            var handlerName = type + "Handler";
            var asm = Assembly.GetExecutingAssembly();

            var t = asm.GetType($"{typeNamespace}.Handlers.{handlerName}");
            return ActivateType(t);
        }

        private IHandler ActivateType(Type t)
        {
            if (t == null)
            {
                throw new Exception($"Handler not found.");
            }

            return Activator.CreateInstance(t) as IHandler;
        }

        public override void OnBackPressed()
        {
            SaveAsync();
            base.OnBackPressed();
        }

        public abstract Task SaveAsync();
    }
}