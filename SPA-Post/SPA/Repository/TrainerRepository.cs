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
    public class TrainerRepository : ITrainerRepository
    {
        SPAContext context = new SPAContext();

        public TrainerRepository()
            : this(new SPAContext())
        {

        }
        public TrainerRepository(SPAContext context)
        {
            this.context = context;
        }


        public IQueryable<Trainer> All
        {
            get { return context.Trainers; }
        }

        public IQueryable<Trainer> AllIncluding(params Expression<Func<Trainer, object>>[] includeProperties)
        {
            IQueryable<Trainer> query = context.Trainers;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Trainer Find(long id)
        {
            return context.Trainers.Find(id);
        }

        public void InsertOrUpdate(Trainer trainer)
        {
            if (trainer.Id == default(long))
            {
                // New entity
                context.Trainers.Add(trainer);
            }
            else
            {
                // Existing entity
                context.Entry(trainer).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var trainer = context.Trainers.Find(id);
            context.Trainers.Remove(trainer);
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

    public interface ITrainerRepository : IDisposable
    {
        IQueryable<Trainer> All { get; }
        IQueryable<Trainer> AllIncluding(params Expression<Func<Trainer, object>>[] includeProperties);
        Trainer Find(long id);
        void InsertOrUpdate(Trainer trainer);
        void Delete(long id);
        void Save();
    }
}