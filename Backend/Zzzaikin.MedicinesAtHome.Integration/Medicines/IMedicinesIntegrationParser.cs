using Zzzaikin.MedicinesAtHome.Models;

namespace Zzzaikin.MedicinesAtHome.Integration.Medicines
{
    public interface IMedicinesIntegrationParser
    {
        Task<IEnumerable<string>> GetMedicinesNamesTask();

        Task<IEnumerable<Medicine>> GetMedicinesFullInfoTask(Task<IEnumerable<string>> medicinesNames); 
    }
}
