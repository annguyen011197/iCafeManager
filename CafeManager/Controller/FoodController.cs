using CafeManager.Model;
using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManager.Utils;
namespace CafeManager.Controller
{
    class FoodController
    {
        private static FoodController instance = null;
        private FoodService foodService;

        public static FoodController getController()
        {
            if (instance == null) instance = new FoodController();
            return instance;
        }

        public FoodController()
        {
            foodService = new FoodService();
        }

        public List<Food> getListFood()
        {
            return foodService.findAll().DataTableToList<Food>();
        }

        public List<Food> getListFoodCategory(int id)
        {
            List<Food> list = getListFood();
            List<Food> listResult = new List<Food>();
            list.ForEach(item =>
            {
                if (item.Category == id)
                {
                    listResult.Add(item);
                }
            });
            return listResult;
        }

        public Food findFood(int id)
        {
            return foodService.findOne(id);
        }
    }
}
