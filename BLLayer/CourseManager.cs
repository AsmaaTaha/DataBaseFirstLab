using ModelLayer;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLayer
{
    public class CourseManager : Repository<Course, SimpleITIEntities>
    {
        public CourseManager(SimpleITIEntities s):base(s)
        {

        }
    }
}
