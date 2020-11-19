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
using static Android.App.ActionBar;

namespace Profus_mobile
{

    [Activity(Label = "Mode de Jeu")]
    public class Mode_de_Jeu : Activity
    {
        public static int Nb_joueur;
        TextView Titre;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.Mode_de_Jeu);

            // Create your application here
            Titre = FindViewById<TextView>(Resource.Id.textView1);
            Titre.Text = Nb_joueur.ToString();


            LinearLayout layout = FindViewById<LinearLayout>(Resource.Id.Linear_Layout_Button_MJ);
            LayoutParams lp = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
            for(int i = 1;i<=Nb_joueur;i++)
            {
                Button button = new Button(this);
                button.Text = "Bouton #" + i;
                button.Click += new EventHandler(this.Button_Click);
                layout.AddView(button, lp);
            }
        }

        void Button_Click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            Titre.Text = btn.Text;
        }
    }
}