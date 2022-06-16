using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
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
       

    }
}
