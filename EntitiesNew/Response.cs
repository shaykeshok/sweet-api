using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesNew
{
    public class DefaultResponse
    {
        public int rc;
        public String desc;
        public String body;
        public String title;
        public String step;
    }

    public class WelcomeResponse : DefaultResponse
    {
        public String about;
    }

    public class GetAllItemsList : DefaultResponse
    {
        public List<FoodItem> Fooditems;
    }

    public class GetSpecificItemsList : DefaultResponse
    {
        public List<FoodItem> Fooditems;
    }
}
