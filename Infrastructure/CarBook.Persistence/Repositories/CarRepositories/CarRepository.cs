using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.CarRepositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CarBookContext context) : base(context)
        {
        }

        public async Task<List<Car>> GetCarsListWithBrands()
        {
            return await _dbSet.Include(x => x.Brand).ToListAsync();
        }
    }
}
