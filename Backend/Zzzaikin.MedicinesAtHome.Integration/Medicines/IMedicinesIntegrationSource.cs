using Zzzaikin.MedicinesAtHome.Models;

namespace Zzzaikin.MedicinesAtHome.Integration.Medicines
{
    public interface IMedicinesIntegrationSource
    {
        Task<IEnumerable<Medicine>> GetMedicinesTask(string medicinesNamesAndLinksUrl,
            string pathToMedicinesNamesAndLinksNodes);
    }
}
