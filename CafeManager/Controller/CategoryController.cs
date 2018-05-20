using CafeManager.Model;
using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManager.Utils;
using System.Data;

namespace CafeManager.Controller
{
    class CategoryController
    {
        private static CategoryController instance = null;
        private CategoryService foodService;

        public static CategoryController getController()
        {
            if (instance == null) instance = new CategoryController();
            return instance;
        }

        public CategoryController()
        {
            foodService = new CategoryService();
        }

        public List<Category> getListCategory()
        {
            return foodService.findAll().DataTableToList<Category>();
        }

        public DataTable getTableCategory()
        {
            return foodService.findAll();
        }
    }
}
