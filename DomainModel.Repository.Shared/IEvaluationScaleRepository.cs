﻿using DomainModel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Repository.Shared
{
    public interface IEvaluationScaleRepository : IRepository<EvaluationScale>
    {
        EvaluationScaleOption GetEvaluationScaleOptionById(int id);
        IEnumerable<EvaluationScaleOption> GetEvaluationScaleOptionsFromScale(int scaleId);
    }
}
