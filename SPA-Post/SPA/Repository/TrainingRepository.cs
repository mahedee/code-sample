using SPA.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SPA.Repository
{ 
    public class TrainingRepository : ITrainingRepository
    {
        SPAContext context = new SPAContext();

        public TrainingRepository()
            : this(new SPAContext())
        {

        }
        public TrainingRepository(SPAContext context)
        {
            this.context = context;
        }

        public IQueryable<Training> All
        {
            get { return context.Trainings; }
        }

        public IQueryable<Training> AllIncluding(params Expression<Func<Training, object>>[] includeProperties)
        {
            IQueryable<Training> query = context.Trainings;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Training Find(long id)
        {
            return context.Trainings.Find(id);
        }

        public void InsertOrUpdate(Training training)
        {
            if (training.Id == default(long)) {
                // New entity
                context.Trainings.Add(training);
            } else {
                // Existing entity
                context.Entry(training).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var training = context.Trainings.Find(id);
            context.Trainings.Remove(training);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }

    public interface ITrainingRepository : IDisposable
    {
        IQueryable<Training> All { get; }
        IQueryable<Training> AllIncluding(params Expression<Func<Training, object>>[] includeProperties);
        Training Find(long id);
        void InsertOrUpdate(Training training);
        void Delete(long id);
        void Save();
    }
}