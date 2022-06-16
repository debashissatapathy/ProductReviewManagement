﻿// See https://aka.ms/new-console-template for more information
using ProductReviewManagement;

Console.WriteLine("Welcome to Product review Management Problem!");

List<ProductReview> productReviewList = new List<ProductReview>()
{
    new ProductReview(){ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 2, UserId = 2, Rating = 4, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 3, UserId = 3, Rating = 5, Review = "Bad", IsLike= true},
    new ProductReview(){ProductId = 4, UserId = 4, Rating = 4, Review = "Good", IsLike = false},
    new ProductReview(){ProductId = 5, UserId = 5, Rating = 2, Review = "Bad", IsLike = false },
    new ProductReview(){ProductId = 6, UserId = 6, Rating = 3, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 7, UserId = 7, Rating = 5, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 8, UserId = 8, Rating = 4, Review = "Good", IsLike = false},
    new ProductReview(){ProductId = 9, UserId = 9, Rating = 1, Review = "Bad", IsLike = false},
    new ProductReview(){ProductId = 10, UserId = 10, Rating = 4, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 11, UserId = 11, Rating = 4, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 12, UserId = 12, Rating = 4, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 13, UserId = 13, Rating = 4, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 14, UserId = 14, Rating = 3, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 15, UserId = 15, Rating = 1, Review = "Bad", IsLike = false},
    new ProductReview(){ProductId = 16, UserId = 16, Rating = 4, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 17, UserId = 17, Rating = 4, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 18, UserId = 18, Rating = 5, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 19, UserId = 19, Rating = 5, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 20, UserId = 20, Rating = 5, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 21, UserId = 21, Rating = 5, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 22, UserId = 22, Rating = 5, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 23, UserId = 23, Rating = 5, Review = "Good", IsLike = false},
    new ProductReview(){ProductId = 24, UserId = 24, Rating = 5, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 25, UserId = 25, Rating = 5, Review = "Good", IsLike = true},
};
foreach(var list in productReviewList)
{
    Console.Write("ProductId: {0}, UserId: {1}, Rating: {2}, Review: {3}, IsLike: {4}",
                        list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
    Console.WriteLine("\n");
}
