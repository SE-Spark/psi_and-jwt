
using System;
using System.Collections.Generic;
using System.Text;

using Authentication.DAL.Entities;
using Authentication.DAL.Repository;

namespace Authentication.BAL.Logics
{
    public class StationLogic
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Station> Get()
        {
            return unitOfWork.StationRepository.Get();
        }
        public Station Get(int nationalId)
        {
            return unitOfWork.StationRepository.GetByID(nationalId);
        }
        public Station Get(Guid Id)
        {
            return unitOfWork.StationRepository.GetByID(Id);
        }
        public int Insert(Station ct)
        {
            unitOfWork.StationRepository.Insert(ct);
            return unitOfWork.Save();
        }
        public int Delete(Guid id)
        {
            unitOfWork.StationRepository.Delete(id);
            return unitOfWork.Save();
        }
        public int Delete(Station ct)
        {
            unitOfWork.StationRepository.Delete(ct);
            return unitOfWork.Save();
        }
        public int Update(Station ct)
        {
            unitOfWork.StationRepository.Update(ct);
            return unitOfWork.Save();
        }
    }
}
