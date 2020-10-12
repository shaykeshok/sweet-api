using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DefaultResponse
    {
        public int rc;
        public String desc;
        public String body;
        public String title;
        public String step;
    }

    public class GetAllItemsList : DefaultResponse
    {
        List<FoodItem> Fooditems;
    }

    public class GetSpecificItemsList : DefaultResponse
    {
        List<FoodItem> Fooditems;
    }
}
