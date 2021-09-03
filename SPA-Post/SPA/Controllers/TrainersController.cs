using SPA.Models;
using SPA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;

namespace SPA.Controllers
{
    public class TrainersController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Trainer> Get()
        {
            List<Trainer> lstTrainer = new List<Trainer>();
            lstTrainer = unitOfWork.TrainerRepository.All.ToList();
            return lstTrainer;
        }

        //// GET api/trainers/5
        public Trainer Get(int id)
        {
            Trainer objTrainer = unitOfWork.TrainerRepository.Find(id);
            return objTrainer;
        }

   
        public HttpResponseMessage Post(Trainer trainer)
        {

            if (ModelState.IsValid)
            {
                unitOfWork.TrainerRepository.InsertOrUpdate(trainer);
                unitOfWork.TrainerRepository.Save();
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return new HttpResponseMessage(HttpStatusCode.InternalServerError);
        }


        private IEnumerable<string> GetErrorMessages()
        {
            return ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage));
        }

   

        // PUT api/trainers/5
        public HttpResponseMessage Put(int Id, Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.TrainerRepository.InsertOrUpdate(trainer);
                unitOfWork.TrainerRepository.Save();
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
        }

        // DELETE api/trainers/5
        public HttpResponseMessage Delete(int id)
        {
            Trainer objTrainer = unitOfWork.TrainerRepository.Find(id);
            if (objTrainer == null)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            unitOfWork.TrainerRepository.Delete(id);
            unitOfWork.TrainerRepository.Save();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
