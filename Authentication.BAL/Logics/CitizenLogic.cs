using System;
using System.Collections.Generic;
using System.Text;
using Authentication.DAL.Entities;
using Authentication.DAL.Repository;
namespace Authentication.BAL.Logics
{
    public class CitizenLogic
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Citizen> Get()
        {
            return unitOfWork.CitizenRepository.Get();
        }
        public Citizen Get(int nationalId)
        {
            return unitOfWork.CitizenRepository.GetByID(nationalId);
        }
        public Citizen Get(Guid Id)
        {
            return unitOfWork.CitizenRepository.GetByID(Id);
        }
        public int Insert(Citizen ct)
        {
            unitOfWork.CitizenRepository.Insert(ct);
           return unitOfWork.Save();
        }
        public int Delete(Guid id)
        {
            unitOfWork.CitizenRepository.Delete(id);
            return unitOfWork.Save();
        }
        public int Delete(Citizen ct)
        {
            unitOfWork.CitizenRepository.Delete(ct);
            return unitOfWork.Save();
        }
        public int Update(Citizen ct)
        {
            unitOfWork.CitizenRepository.Update(ct);
            return unitOfWork.Save();
        }
    }
}
