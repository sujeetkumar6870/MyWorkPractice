using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class MainDAL
    {
        ProductionHouseEntities DALObj = new ProductionHouseEntities();

        public void GetData()
        {
            var _resGetData = from t in DALObj.ProducerEntities
                              select t;
        }
    }
}
