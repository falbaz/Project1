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

namespace MovieReviews
{
    [Activity(Label = "Movie1Activity")]
    public class Movie1Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Movie1Layout);
        
            // Get our button from the layout resource,
            // and attach an event to it
            TextView text_movie_name_for_review1 = FindViewById<TextView>(Resource.Id.text_movie_name_for_review1);
            EditText text_movie_rating_for_review1 = FindViewById<EditText>(Resource.Id.text_movie_rating_for_review1);
            Button button_rate_movie1_1 = FindViewById<Button>(Resource.Id.button_rate_movie1_1);
            Button button_rate_movie1_2 = FindViewById<Button>(Resource.Id.button_rate_movie1_2);
            Button button_rate_movie1_3 = FindViewById<Button>(Resource.Id.button_rate_movie1_3);
            Button button_rate_movie1_4 = FindViewById<Button>(Resource.Id.button_rate_movie1_4);
            Button button_rate_movie1_5 = FindViewById<Button>(Resource.Id.button_rate_movie1_5);

            Code.Movie m1 = Code.TestData.GetMovie1();

            text_movie_name_for_review1.Text = m1.MovieName;
            text_movie_rating_for_review1.Text = m1.ToString();

            button_rate_movie1_1.Click +=
                delegate {
                    m1.AddReview(1);
                    text_movie_rating_for_review1.Text = m1.ToString();
                };

            button_rate_movie1_2.Click +=
               delegate {
                   m1.AddReview(2);
                   text_movie_rating_for_review1.Text = m1.ToString();
               };

            button_rate_movie1_3.Click +=
               delegate {
                   m1.AddReview(3);
                   text_movie_rating_for_review1.Text = m1.ToString();
               };

            button_rate_movie1_4.Click +=
               delegate {
                   m1.AddReview(4);
                   text_movie_rating_for_review1.Text = m1.ToString();
               };

            button_rate_movie1_5.Click +=
               delegate {
                   m1.AddReview(5);
                   text_movie_rating_for_review1.Text = m1.ToString();
               };
        }
    }
}