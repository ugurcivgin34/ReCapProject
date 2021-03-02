using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;



namespace DataAccess.Create.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase <Car,ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = c.Descriptions,
                                 ColorName = co.ColorName,
                                 DailyPrice=c.DailyPrice
                
                             };
                             
                return result.ToList();
            }
        }


    }
    
        
	

	
    
}
