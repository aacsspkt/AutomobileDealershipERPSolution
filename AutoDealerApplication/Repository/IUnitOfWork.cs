﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealerApplication.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IMeasurementRepository Measurements { get; }
        bool Complete();
    }
}
