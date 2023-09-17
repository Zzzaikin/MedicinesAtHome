using Zzzaikin.MedicinesAtHome.Models;

namespace Zzzaikin.MedicinesAtHome.Integration.Medicines
{
    public interface IMedicinesIntegrator
    {
        Task<IEnumerable<Medicine>> GetMedicinesTask();
    }
}
