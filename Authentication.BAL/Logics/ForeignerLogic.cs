
using System;
using System.Collections.Generic;
using System.Text;
using Authentication.DAL.Entities;
using Authentication.DAL.Repository;

namespace Authentication.BAL.Logics
{
    public class ForeignerLogic
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Foreigner> Get()
        {
            return unitOfWork.ForeignerRepository.Get();
        }
        public Foreigner Get(int nationalId)
        {
            return unitOfWork.ForeignerRepository.GetByID(nationalId);
        }
        public Foreigner Get(Guid Id)
        {
            return unitOfWork.ForeignerRepository.GetByID(Id);
        }
        public int Insert(Foreigner ct)
        {
            unitOfWork.ForeignerRepository.Insert(ct);
            return unitOfWork.Save();
        }
        public int Delete(Guid id)
        {
            unitOfWork.ForeignerRepository.Delete(id);
            return unitOfWork.Save();
        }
        public int Delete(Foreigner ct)
        {
            unitOfWork.ForeignerRepository.Delete(ct);
            return unitOfWork.Save();
        }
        public int Update(Foreigner ct)
        {
            unitOfWork.ForeignerRepository.Update(ct);
            return unitOfWork.Save();
        }
    }
}
