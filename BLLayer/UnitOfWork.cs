using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BLLayer;
namespace BLLayer
{
   public class UnitOfWork
    {
        static SimpleITIEntities e = new SimpleITIEntities();
        static UnitOfWork unitOfWork;
        private UnitOfWork()
        {

        }
        public CourseManager CourseManager { get { return new CourseManager(e); } }
        public StudetManager StudentManager { get { return new StudetManager(e); } }
  
        public static UnitOfWork Create()
        {
            if (unitOfWork==null)
            {
                unitOfWork = new UnitOfWork();
            }
           
                return unitOfWork;
            
        }
    }
}
