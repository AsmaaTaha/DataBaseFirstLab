using ModelLayer;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLayer
{
   public class StudetManager:Repository<Student ,SimpleITIEntities>
    {
        public StudetManager(SimpleITIEntities s):base(s)
        {

        }
    }
}
