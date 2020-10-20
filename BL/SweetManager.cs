using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesNew;
using DAL;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using SystemUtils;

namespace BL
{
    public class SweetManager : IDisposable
    {


        public SweetManager() { }

        // clear all resource memory leak 
        public void Dispose()
        {
        }

        public List<FoodItem> GetAllFoodItems()
        {
            List<FoodItem> foodList = new List<FoodItem>();
            string query = "select * from food where isActive=1";
            using (DALsweets dal = new DALsweets())
            {
                MySqlDataReader dataReader = dal.ExecuteReader(query);
                while (dataReader.Read())
                {
                    FoodItem item = new FoodItem()
                    {
                        _id = (int)utils.Nz(dataReader["idfood"], 0),
                        foodName = (string)utils.Nz(dataReader["name"], ""),
                        price = (float)utils.Nz(dataReader["price"], 0),
                        category = (int)utils.Nz(dataReader["category"], 0),
                        description = (string)utils.Nz(dataReader["desc"], ""),
                        imageUrl = (string)utils.Nz(dataReader["img"], ""),
                        productVisibility= Convert.ToBoolean(utils.Nz(dataReader["isActive"], 0))
                    };

                    foodList.Add(item);
                }

            }
            return foodList;
        }

    }
}
