
using System;
using System.Collections.Generic;
using System.Text;
using Authentication.DAL.Entities;
using Authentication.DAL.Repository;

namespace Authentication.BAL.Logics
{
    class CriminalLogic
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Criminal> Get()
        {
            return unitOfWork.CriminalRepository.Get();
        }
        public Criminal Get(int nationalId)
        {
            return unitOfWork.CriminalRepository.GetByID(nationalId);
        }
        public Criminal Get(Guid Id)
        {
            return unitOfWork.CriminalRepository.GetByID(Id);
        }
        public int Insert(Criminal ct)
        {
            unitOfWork.CriminalRepository.Insert(ct);
            return unitOfWork.Save();
        }
        public int Delete(Guid id)
        {
            unitOfWork.CriminalRepository.Delete(id);
            return unitOfWork.Save();
        }
        public int Delete(Criminal ct)
        {
            unitOfWork.CriminalRepository.Delete(ct);
            return unitOfWork.Save();
        }
        public int Update(Criminal ct)
        {
            unitOfWork.CriminalRepository.Update(ct);
            return unitOfWork.Save();
        }
    }
}
