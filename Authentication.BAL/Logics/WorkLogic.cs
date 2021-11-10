
using System;
using System.Collections.Generic;
using System.Text;
using Authentication.DAL.Entities;
using Authentication.DAL.Repository;

namespace Authentication.BAL.Logics
{
    public class WorkLogic
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Work> Get()
        {
            return unitOfWork.WorkRepository.Get();
        }
        public Work Get(int nationalId)
        {
            return unitOfWork.WorkRepository.GetByID(nationalId);
        }
        public Work Get(Guid Id)
        {
            return unitOfWork.WorkRepository.GetByID(Id);
        }
        public int Insert(Work ct)
        {
            unitOfWork.WorkRepository.Insert(ct);
            return unitOfWork.Save();
        }
        public int Delete(Guid id)
        {
            unitOfWork.WorkRepository.Delete(id);
            return unitOfWork.Save();
        }
        public int Delete(Work ct)
        {
            unitOfWork.WorkRepository.Delete(ct);
            return unitOfWork.Save();
        }
        public int Update(Work ct)
        {
            unitOfWork.WorkRepository.Update(ct);
            return unitOfWork.Save();
        }
    }
}
