// See https://aka.ms/new-console-template for more information
using ProductReviewManagement;

Console.WriteLine("Welcome to Product review Management Problem!");
//UC1: 25 default value added in list
List<ProductReview> productReviewList = new List<ProductReview>()
{
    new ProductReview(){ProductId = 1, UserId = 1, Rating = 2, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 2, UserId = 2, Rating = 4, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 3, UserId = 3, Rating = 3, Review = "Bad", IsLike= true},
    new ProductReview(){ProductId = 4, UserId = 4, Rating = 4.5, Review = "Good", IsLike = false},
    new ProductReview(){ProductId = 5, UserId = 5, Rating = 8, Review = "Bad", IsLike = false },
    new ProductReview(){ProductId = 6, UserId = 6, Rating = 7, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 7, UserId = 7, Rating = 5, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 8, UserId = 8, Rating = 9, Review = "Good", IsLike = false},
    new ProductReview(){ProductId = 9, UserId = 9, Rating = 3, Review = "Bad", IsLike = false},
    new ProductReview(){ProductId = 10, UserId = 10, Rating = 6.5, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 11, UserId = 11, Rating = 8, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 12, UserId = 12, Rating = 1, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 13, UserId = 13, Rating = 3.5, Review = "Nice", IsLike = true},
    new ProductReview(){ProductId = 14, UserId = 14, Rating = 7.5, Review = "Good", IsLike = true},
    new ProductReview(){ProductId = 15, UserId = 15, Rating = 2, Review = "Bad", IsLike = false},
    new ProductReview(){ProductId = 16, UserId = 16, Rating = 5, Review = "Nice", IsLike = true},
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

Console.WriteLine("Choose an option to take action: \n1.UC1: Add 25 default value\n2.//UC2: Fetch top 3 records" +
                    "\n3.UC3: record who’s rating > 3 and productID is 1 or 4 or 9\n4.UC4: count of review ineach productID" +
                    "\n5.UC5: Retrieve productId and review\n6.UC6: Skip top 5 records\n7.UC7: Retrieve productId and review" +
                    "\n8.Create Datatable\n9. fetch who's review is true\n10.Avarege Rating\n11.review message contains “nice”" +
                    "\n12.Retrieve Userid = 10 and order by rating");
int option = Convert.ToInt16(Console.ReadLine());
Management management = new Management();
while (true)
{
    switch (option)
    {
        case 1:
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductId: {0}, UserId: {1}, Rating: {2}, Review: {3}, IsLike: {4}",
                                    list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
            }
            break;
        case 2:
            management.TopRecord(productReviewList);
            break;
        case 3:
            management.SelectedRecord(productReviewList);
            break;
        case 4:
            management.CountOfRecord(productReviewList);
            break;
        case 5:
            management.Retrieve_ProductId_Review(productReviewList);
            break;
        case 6:
            management.SkipTop5Records(productReviewList);
            break;
        case 7:
            management.Retrieve_ProductId_Review(productReviewList);
            break;
        case 8:
            management.CreateDataTable();
            break;
        case 9:
            management.Retrieve_IsLike_True(productReviewList);
            break;
        case 10:


            List<ProductReview> productList = new List<ProductReview>();

            productList.Add(new ProductReview() { ProductId = 1, UserId = 1, Rating = 2, Review = "Good", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 1, UserId = 2, Rating = 4, Review = "Good", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 2, UserId = 3, Rating = 3, Review = "Bad", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 2, UserId = 4, Rating = 4.5, Review = "Good", IsLike = false });
            productList.Add(new ProductReview() { ProductId = 3, UserId = 5, Rating = 8, Review = "Bad", IsLike = false });
            productList.Add(new ProductReview() { ProductId = 3, UserId = 6, Rating = 7, Review = "Nice", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 4, UserId = 7, Rating = 5, Review = "Nice", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 4, UserId = 8, Rating = 9, Review = "Good", IsLike = false });
            productList.Add(new ProductReview() { ProductId = 5, UserId = 9, Rating = 3, Review = "Bad", IsLike = false });
            productList.Add(new ProductReview() { ProductId = 5, UserId = 10, Rating = 6.5, Review = "Nice", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 6, UserId = 11, Rating = 8, Review = "Nice", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 6, UserId = 12, Rating = 1, Review = "Nice", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 7, UserId = 13, Rating = 3.5, Review = "Nice", IsLike = true });
            productList.Add(new ProductReview() { ProductId = 7, UserId = 14, Rating = 7.5, Review = "Good", IsLike = true });
            management.AvaregeRating(productList);
            break;
        case 11:
            management.Review_Contains_Nice(productReviewList);
            break;
        case 12:
            List<ProductReview> reviewList = new List<ProductReview>();

            reviewList.Add(new ProductReview() { ProductId = 1, UserId = 1, Rating = 2, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 2, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 3, Rating = 3, Review = "Bad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 4, Rating = 4.5, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 5, Rating = 8, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 6, Rating = 7, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 7, Rating = 5, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 8, Rating = 9, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 9, Rating = 3, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 5, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 6, Review = "Bad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 9, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 3, Review = "Bad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 1, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 11, Rating = 8, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 12, Rating = 1, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 13, UserId = 13, Rating = 3.5, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 14, UserId = 14, Rating = 7.5, Review = "Good", IsLike = true });
            
            management.Retieve_UserId10(reviewList);
            break;


    }        

            
    
}
    
    
    

