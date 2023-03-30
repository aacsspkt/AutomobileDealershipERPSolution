using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoDealerApplication.AppState;
using AutoDealerApplication.Models;

namespace AutoDealerApplication.Repository
{
    public class MeasurementRepository : BaseRepository<Measurement>, IMeasurementRepository
    {
        public MeasurementRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
