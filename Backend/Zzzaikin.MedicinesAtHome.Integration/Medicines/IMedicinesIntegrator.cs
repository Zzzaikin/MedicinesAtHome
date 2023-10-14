using Zzzaikin.MedicinesAtHome.Models;

namespace Zzzaikin.MedicinesAtHome.Integration.Medicines
{
    // TODO: Create the service on this project to use it for updating medicines database.
    public interface IMedicinesIntegrator
    {
        Task<IEnumerable<Medicine>> GetMedicinesTask();
    }
}
