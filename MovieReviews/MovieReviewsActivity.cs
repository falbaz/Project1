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
    [Activity(Label = "MovieReviewsActivity")]
    public class MovieReviewsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MovieReviews);

            // Get our button from the layout resource,
            // and attach an event to it
            TextView movie_1_name = FindViewById<TextView>(Resource.Id.textMovie1);
            EditText movie_1_review = FindViewById<EditText>(Resource.Id.textReview1);
            Button review_1_button = FindViewById<Button>(Resource.Id.buttonAddReview1);

            TextView movie_2_name = FindViewById<TextView>(Resource.Id.textMovie2);
            EditText movie_2_review = FindViewById<EditText>(Resource.Id.textReview2);
            Button review_2_button = FindViewById<Button>(Resource.Id.buttonAddReview2);

            TextView movie_3_name = FindViewById<TextView>(Resource.Id.textMovie3);
            EditText movie_3_review = FindViewById<EditText>(Resource.Id.textReview3);
            Button review_3_button = FindViewById<Button>(Resource.Id.buttonAddReview3);

            Code.Movie m1 = Code.TestData.GetMovie1();
            Code.Movie m2 = Code.TestData.GetMovie2();
            Code.Movie m3 = Code.TestData.GetMovie3();

            movie_1_name.Text = m1.MovieName;
            movie_2_name.Text = m2.MovieName;
            movie_3_name.Text = m3.MovieName;

            movie_1_review.Text = m1.ToString();
            movie_2_review.Text = m2.ToString();
            movie_3_review.Text = m3.ToString();

            review_1_button.Click +=
                delegate {
                    StartActivity(typeof(Movie1Activity));
                };

            review_2_button.Click +=
                delegate {
                    
                };

            review_3_button.Click +=
                delegate {
                    
                };
        }
    }
}