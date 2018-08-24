using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _5eCharacterBuilder.ViewModels;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace _5eCharacterBuilder.Utilities
{
    public class ListViewAdapter : BaseAdapter<Character>
    {
        private readonly Context ctx;
        private readonly List<Character> characters;

        public ListViewAdapter(Context ctx, List<Character> characters)
        {
            this.ctx = ctx;
            this.characters = characters;
        }
        public override Character this[int position]
        {
            get { return characters[position]; }
        }

        public override int Count => this.characters.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var row = convertView;
            if(row == null)
            {
                row = LayoutInflater.FromContext(ctx).Inflate(Resource.Layout.CharacterListView, null, false);
            }

            var characterName = row.FindViewById<TextView>(Resource.Id.CharacterNameTextView);
            var playerName = row.FindViewById<TextView>(Resource.Id.PlayerNameTextView);

            characterName.Text = characters[position].Name;
            playerName.Text = characters[position].PlayerName;

            return row;
        }
    }
}