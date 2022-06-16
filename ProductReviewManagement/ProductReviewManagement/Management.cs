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
        public readonly DataTable datatable = new DataTable();

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
        //UC3: Management - Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9
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

    }
}
