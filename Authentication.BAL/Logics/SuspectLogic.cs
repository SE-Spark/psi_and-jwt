
using System;
using System.Collections.Generic;
using System.Text;

using Authentication.DAL.Entities;
using Authentication.DAL.Repository;

namespace Authentication.BAL.Logics
{
    public class SuspectLogic
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Suspect> Get()
        {
            return unitOfWork.SuspectRepository.Get();
        }
        public Suspect Get(int nationalId)
        {
            return unitOfWork.SuspectRepository.GetByID(nationalId);
        }
        public Suspect Get(Guid Id)
        {
            return unitOfWork.SuspectRepository.GetByID(Id);
        }
        public int Insert(Suspect ct)
        {
            unitOfWork.SuspectRepository.Insert(ct);
            return unitOfWork.Save();
        }
        public int Delete(Guid id)
        {
            unitOfWork.SuspectRepository.Delete(id);
            return unitOfWork.Save();
        }
        public int Delete(Suspect ct)
        {
            unitOfWork.SuspectRepository.Delete(ct);
            return unitOfWork.Save();
        }
        public int Update(Suspect ct)
        {
            unitOfWork.SuspectRepository.Update(ct);
            return unitOfWork.Save();
        }
    }
}
