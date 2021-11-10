using Authentication.DAL.Database;
using Authentication.DAL.Entities;
using Authentication.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.DAL.Repository
{
    public class UnitOfWork:IDisposable
    {

        private DatabaseContext context = new DatabaseContext(DatabaseContext.ops.opts);
        private GenericRepository<Citizen> citizenRepository;
        private GenericRepository<Criminal> criminalRepository;
        private GenericRepository<Foreigner> courseRepository;
        private GenericRepository<Officer> officerRepository;
        private GenericRepository<Station> stationRepository;
        private GenericRepository<Suspect> suspectRepository;
        private GenericRepository<Work> workRepository;

        public GenericRepository<Citizen> CitizenRepository
        {
            get
            {

                if (this.citizenRepository == null)
                {
                    this.citizenRepository = new GenericRepository<Citizen>(context);
                }
                return citizenRepository;
            }
        }
        public GenericRepository<Criminal> CriminalRepository
        {
            get
            {

                if (this.criminalRepository == null)
                {
                    this.criminalRepository = new GenericRepository<Criminal>(context);
                }
                return criminalRepository;
            }
        }
        public GenericRepository<Foreigner> ForeignerRepository
        {
            get
            {

                if (this.courseRepository == null)
                {
                    this.courseRepository = new GenericRepository<Foreigner>(context);
                }
                return courseRepository;
            }
        }
        public GenericRepository<Officer> OfficerRepository
        {
            get
            {

                if (this.officerRepository == null)
                {
                    this.officerRepository = new GenericRepository<Officer>(context);
                }
                return officerRepository;
            }
        }
        public GenericRepository<Station> StationRepository
        {
            get
            {

                if (this.stationRepository == null)
                {
                    this.stationRepository = new GenericRepository<Station>(context);
                }
                return stationRepository;
            }
        }
        public GenericRepository<Suspect> SuspectRepository
        {
            get
            {

                if (this.suspectRepository == null)
                {
                    this.suspectRepository = new GenericRepository<Suspect>(context);
                }
                return suspectRepository;
            }
        }
        public GenericRepository<Work> WorkRepository
        {
            get
            {

                if (this.workRepository == null)
                {
                    this.workRepository = new GenericRepository<Work>(context);
                }
                return workRepository;
            }
        }


       
        public int Save()
        {
           return context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
