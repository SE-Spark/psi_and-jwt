
using System;
using System.Collections.Generic;
using System.Text;

using Authentication.DAL.Entities;
using Authentication.DAL.Repository;

namespace Authentication.BAL.Logics
{
    public class OfficerLogic
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Officer> Get()
        {
            return unitOfWork.OfficerRepository.Get();
        }
        public Officer Get(int nationalId)
        {
            return unitOfWork.OfficerRepository.GetByID(nationalId);
        }
        public Officer Get(Guid Id)
        {
            return unitOfWork.OfficerRepository.GetByID(Id);
        }
        public int Insert(Officer ct)
        {
            unitOfWork.OfficerRepository.Insert(ct);
            return unitOfWork.Save();
        }
        public int Delete(Guid id)
        {
            unitOfWork.OfficerRepository.Delete(id);
            return unitOfWork.Save();
        }
        public int Delete(Officer ct)
        {
            unitOfWork.OfficerRepository.Delete(ct);
            return unitOfWork.Save();
        }
        public int Update(Officer ct)
        {
            unitOfWork.OfficerRepository.Update(ct);
            return unitOfWork.Save();
        }
    }
}
