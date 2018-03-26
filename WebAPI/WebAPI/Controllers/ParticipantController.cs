using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ParticipantController : ApiController
    {
        [HttpPost]
        [Route("api/InsertParticipant")]
        public Participant Insert(Participant model)
        {
            using (DBModels db = new DBModels())
            {
                db.Participants.Add(model);
                db.SaveChanges();
                return model;
            }

        }

        [HttpPost]
        [Route("api/UpdateOutPut")]
        public void UpdateOutPut(Participant model)
        {
            using (DBModels db = new DBModels())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
    }
}
