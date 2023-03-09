using MotorIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MotorIntegration.Controllers
{
    public class MotorController : ApiController
    {

        public IEnumerable<GetMotor> Get()
        {
            using (INSUREJOYEntities entities = new INSUREJOYEntities())
            {
                return entities.GetMotors.ToList();
            }
        }
        public GetMotor Get(string id)
        {
            using (INSUREJOYEntities entities = new INSUREJOYEntities())
            {
                return entities.GetMotors.FirstOrDefault(x => x.VehicleLookupResponseId == id);
            }
        }
        public void Post([FromBody] GetMotor motor)
        {
            using (INSUREJOYEntities entities=new INSUREJOYEntities())
            {
                entities.GetMotors.Add(motor);
                entities.SaveChanges();
            }
        }
    }
}
