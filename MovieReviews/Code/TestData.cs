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

namespace MovieReviews.Code
{
    class TestData
    {
        public static Movie m1;
        public static Movie m2;
        public static Movie m3;

        public static Movie GetMovie1()
        {
            if(m1==null)
            {
                m1 = new Code.Movie("Shawshank Redemption");
                m1.AddReview(2);
                m1.AddReview(1);
                m1.AddReview(3);
                m1.AddReview(3);
                m1.AddReview(4);
                m1.AddReview(5);
                m1.AddReview(5);
                m1.AddReview(5);
                m1.AddReview(5);
            }

            return m1;
        }

        public static Movie GetMovie2()
        {
            if (m2 == null)
            {
                m2 = new Code.Movie("Mr and Mrs Smith");
                m2.AddReview(2);
                m2.AddReview(1);
                m2.AddReview(3);
                m2.AddReview(3);
                m2.AddReview(4);
                m2.AddReview(5);
                m2.AddReview(5);
                m2.AddReview(5);
                m2.AddReview(5);
            }

            return m2;
        }

        public static Movie GetMovie3()
        {
            if (m3 == null)
            {
                m3 = new Code.Movie("Iron Man 3");
                m3.AddReview(2);
                m3.AddReview(1);
                m3.AddReview(3);
                m3.AddReview(3);
                m3.AddReview(4);
                m3.AddReview(5);
                m3.AddReview(5);
                m3.AddReview(5);
                m3.AddReview(5);
            }

            return m3;
        }
    }
}