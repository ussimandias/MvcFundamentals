using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OdeToFood.Models;

namespace OdeToFood.Queries
{
    public static class RestaurantReviewQueries
    {
        public static IEnumerable<ReviewDB> FindTheLatest(
            this IQueryable<ReviewDB> reviews, int numberOfReviews)
        {
            return reviews.OrderByDescending(r => r.Created)
                          .Take(numberOfReviews);
        }

        public static ReviewDB FindById(
            this IQueryable<ReviewDB> reviews, int id)
        {
            return reviews.Single(r => r.ID == id);
        }

        public static ReviewDB FindTheBest(
            this IQueryable<ReviewDB> reviews)
        {
            return reviews.OrderByDescending(r => r.Rating).First();
        }
    }
}