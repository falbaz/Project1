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
    class Movie
    {
        private String _MovieName;
        private List<int> _Reviews;

        public Movie()
        {
            _MovieName = "";
            _Reviews = new List<int>();
        }

        public Movie(String movieName)
        {
            _MovieName = movieName;
            _Reviews = new List<int>();
        }

        public String MovieName
        {
            get { return _MovieName; }
        }

        public void AddReview(int review)
        {
            _Reviews.Add(review);
        }

        private int GetReviews(int reviewNo)
        {
            int count = 0;
            foreach(int r in _Reviews)
            {
                if(r==reviewNo)
                {
                    count++;
                }
            }
            return count;
        }

        public int FiveStarReviews
        {
            get
            {
                return GetReviews(5);
            }
        }

        public int FourStarReviews
        {
            get
            {
                return GetReviews(4);
            }
        }

        public int ThreeStarReviews
        {
            get
            {
                return GetReviews(3);
            }
        }

        public int TwoStarReviews
        {
            get
            {
                return GetReviews(2);
            }
        }

        public int OneStarReviews
        {
            get
            {
                return GetReviews(1);
            }
        }

        public int AverageRating
        {
            get
            {
                int count = 0;
                int sum = 0;
                foreach (int r in _Reviews)
                {
                    count++;
                    sum += r;
                }

                if (count != 0)
                    return (int)sum / count;
                else
                    return 0;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_Reviews.Count + " reviews / ");
            for(int i=1;i<=AverageRating;i++)
            {
                sb.Append("*");
            }
            return sb.ToString();
        }
    }
}