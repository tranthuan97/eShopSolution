using eShopSolution.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }

        //cho phép null nếu có ? đằng sau kiểu dữ liệu
        public int? ParentId { get; set; }
        public Status Status { get; set; }


        //kết nôsi 2 bảng
        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }

    }
}
