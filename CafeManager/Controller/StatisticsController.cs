using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Controller
{
    class StatisticsController
    {
        private static StatisticsController instance = null;
        private StatisticsService service;

        public static StatisticsController getController()
        {
            if (instance == null) instance = new StatisticsController();
            return instance;
        }

        public StatisticsController()
        {
            service = new StatisticsService();
        }

        public DataTable findAll()
        {
            return service.findAll();
        }

        public DataTable findWithOffset(int offset, int limit)
        {
            return service.findWithOffset(offset, limit);
        }

        public DataTable findWithOffset(int offset, int limit, String dayStart, String dayEnd)
        {
            return service.findWithOffset(offset, limit,dayStart, dayEnd);
        }

        public DataTable findWithOffsetGroupbyFood(int offset, int limit, String dayStart, String dayEnd)
        {
            return service.findWithOffsetGroupbyFood(offset, limit,dayStart, dayEnd);
        }

        public DataTable findWithOffsetGroupbyDate(int offset, int limit, String dayStart, String dayEnd)
        {
            return service.findWithOffsetGroupbyDate(offset, limit, dayStart, dayEnd);
        }
    }
}
