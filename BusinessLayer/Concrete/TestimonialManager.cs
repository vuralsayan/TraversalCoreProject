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
    public class TestimonialManager : ITestimonialsService
    {
        ITestimonialsDal _testimonialsDal;

        public TestimonialManager(ITestimonialsDal testimonialsDal)
        {
            _testimonialsDal = testimonialsDal;
        }

        public void TAdd(Testimonials t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonials t)
        {
            throw new NotImplementedException();
        }

        public Testimonials TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonials> TGetList()
        {
            return _testimonialsDal.GetList();
        }

        public void TUpdate(Testimonials t)
        {
            throw new NotImplementedException();
        }
    }
}
