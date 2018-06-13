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
    class TableController
    {
        private static TableController instance = null;
        private TableService tableService;

        public static TableController getController()
        {
            if (instance == null) instance = new TableController();
            return instance;
        }

        public TableController()
        {
            tableService = new TableService();
        }

        public List<Table> getListTable()
        {
            return tableService.findAll().DataTableToList<Table>();
        }

        public bool createTable(Table table)
        {
            return tableService.save(table);
        }

        public void saveTable(Table table)
        {
            tableService.update(table);
        }

        public DataTable findAll()
        {
            return tableService.findAll();
        }

        public void Delete(int ID)
        {
            tableService.delete(ID);
        }
    }
}
