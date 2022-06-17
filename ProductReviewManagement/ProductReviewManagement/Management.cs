using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    //UC2: Fetch top 3 records from ProductReview list
    public class Management
    {
        //public readonly DataTable dataTable = new DataTable();

        public void TopRecord(List<ProductReview> listreview)
        {
            var recordData = (from productReviews in listreview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);
            foreach(var list in recordData)
            {
                Console.WriteLine("ProductId: {0}, UserId: {1}, Rating: {2}, Review: {3}, IsLike: {4}",
                        list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
            }
        }
        //UC3: Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9
       public void SelectedRecord(List<ProductReview> listreview)
       {
            var recordData = (from productReviews in listreview
                              where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                                     && (productReviews.Rating > 3)                                     
                              select productReviews);
            foreach(var list in recordData)
            {
                Console.WriteLine("ProductId: {0}, UserId: {1}, Rating: {2}, Review: {3}, IsLike: {4}",
                        list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
            }
        }
        //UC4: Retrieve count of review present for each productID
        public void CountOfRecord(List<ProductReview> listreview)
        {
            var recordData = listreview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach(var list in recordData)
            {
                Console.WriteLine(list.ProductId + ":: " + list.Count);
            }
        }
        //UC5: Retrieve only productId and review from the list for all records.
        public void Retrieve_ProductId_Review(List<ProductReview> listreview)
        {
            var recordData =  listreview.Select (x => new {productId = x.ProductId, productReview = x.Review });
            foreach( var list in recordData)
            {
                Console.WriteLine("ProductId: {0},  Review: {1}", list.productId, list.productReview);
            }
        }
        //UC6: Skip top 5 records from the list
        public void SkipTop5Records(List<ProductReview> listreview)
        {
            var recordData = (from productReviews in listreview
                              select productReviews).Skip(5);
            foreach( var list in recordData)
            {
                Console.WriteLine("ProductId: {0}, UserId: {1}, Rating: {2}, Review: {3}, IsLike: {4}",
                        list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
            }    
        }
        //UC8: Create DataTable using C# and Add ProductID, UserID, Rating, Review and isLike fields in that.
                //Add 25 default values in datatable list which we have UC created 8

        public void CreateDataTable()
        {
            //Create datatable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductID");
            dataTable.Columns.Add("UserID");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike");

            //Create row
            dataTable.Rows.Add(1, 1, 2, "Good", true);
            dataTable.Rows.Add(2, 2, 4, "Good", true);
            dataTable.Rows.Add(3, 3, 1, "Bad",  true);
            dataTable.Rows.Add(4, 4, 5, "Good", false);
            dataTable.Rows.Add(5, 5, 1, "Bad", false);
            dataTable.Rows.Add(6, 6, 5, "Nice",true);
            dataTable.Rows.Add(7, 7, 5, "Nice", true);
            dataTable.Rows.Add(8, 8, 4 , "Good", false);
            dataTable.Rows.Add(9, 9, 2, "Bad", false);
            dataTable.Rows.Add(10, 10, 3, "Good", true); 
            dataTable.Rows.Add(11, 11, 4, "Good", true);
            dataTable.Rows.Add(12 , 12, 1, "Bad", true);
            dataTable.Rows.Add(13, 13, 5, "Nice", true);
            dataTable.Rows.Add(14, 14, 1, "Bad", true);
            dataTable.Rows.Add(15, 15,5, "Good", false);
            dataTable.Rows.Add(16, 16,1, "Bad", false);
            dataTable.Rows.Add(17, 17,5, "Nice", true);
            dataTable.Rows.Add(18, 18,5, "Nice", true);
            dataTable.Rows.Add(19, 19,4, "Good", false);
            dataTable.Rows.Add(20, 20,2, "Bad", false);
            dataTable.Rows.Add(21, 21,3, "Good", true);
            dataTable.Rows.Add(22, 22,4, "Good", true);
            dataTable.Rows.Add(23, 23,1, "Bad", true);
            dataTable.Rows.Add(24, 24,5, "Nice", true);
            dataTable.Rows.Add(25, 25,4, "Good", false);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***********All Data from the dataTable************");
            Console.ResetColor();
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Review"]}\t|{row["Rating"]}\t|{row["Islike"]}");
            }
        }
        //UC9: Retrieve all the records from the datatable variable who’s isLike value is true
        public void Retrieve_IsLike_True(List<ProductReview> listreview)
        {
            var recordData = (from productReviews in listreview
                              where (productReviews.IsLike == true)
                              select productReviews);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId: {0}, UserId: {1}, Rating: {2}, Review: {3}, IsLike: {4}",
                        list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
            }
        }
        //UC10: Find average rating of the each productId

        public void AvaregeRating(List<ProductReview> listreview)
        {
            var recordData = listreview.GroupBy(x => x.ProductId).Select(x => new
            {
                product = x.Key,
                Count = x.Average(a => a.Rating)
            });
            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id:{0} => Average Rating :{1}", list.product, list.Count);
            }
        }
        //UC11: Retreive all records from the list who’s review message contains “nice”
        public void Review_Contains_Nice(List<ProductReview> listreview)
        {
            var recordData = (from productReviews in listreview
                              where productReviews.Review == "Nice"
                              select productReviews);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId: {0}, UserId: {1}, Rating: {2}, Review: {3}, IsLike: {4}",
                                     list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
            }
        }
        //UC12: all records from the list who’s Userid = 10 and order by rating
        public void Retieve_UserId10(List<ProductReview> listview)
        {
            var recordData = (from productreviews in listview
                              where productreviews.UserId == 10
                              orderby productreviews.Rating
                              select productreviews);
            foreach(var list in recordData)
            {
                Console.WriteLine("ProductId: {0}, UserId: {1}, Rating: {2}, Review: {3}, IsLike: {4}",
                                    list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
            }
        }
    }
}
