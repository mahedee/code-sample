using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA.Repository
{
    public class UnitOfWork : IDisposable
    {
        private SPAContext context;
        public UnitOfWork()
        {
            context = new SPAContext();
        }

        public UnitOfWork(SPAContext _context)
        {
            this.context = _context;
        }

        private TrainingRepository _trainingRepository;

        public TrainingRepository TrainingRepository
        {
            get
            {

                if (this._trainingRepository == null)
                {
                    this._trainingRepository = new TrainingRepository(context);
                }
                return _trainingRepository;
            }
        }


        private TrainerRepository _trainerRepository;

        public TrainerRepository TrainerRepository
        {
            get
            {

                if (this._trainerRepository == null)
                {
                    this._trainerRepository = new TrainerRepository(context);
                }
                return _trainerRepository;
            }
        }




        
        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}