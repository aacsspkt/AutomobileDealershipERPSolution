using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoDealerApplication.AppState;

namespace AutoDealerApplication.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;

            Measurements = new MeasurementRepository(_context);
        }

        public IMeasurementRepository Measurements { get; private set; }

        public bool Complete() => _context.SaveChanges() > 0;

        public void Dispose() => _context.Dispose();
    }
}
