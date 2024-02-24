using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeaturesService
    {
        IFeaturesDal _featuresDal;

        public FeatureManager(IFeaturesDal featuresDal)
        {
            _featuresDal = featuresDal;
        }

        public void TAdd(Features t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Features t)
        {
            throw new NotImplementedException();
        }

        public Features TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Features> TGetList()
        {
            return _featuresDal.GetList();
        }

        public void TUpdate(Features t)
        {
            throw new NotImplementedException();
        }
    }
}
