using Zzzaikin.MedicinesAtHome.Models;
using ZzzArgument = Zzzaikin.Argument.Argument;
using Zzzaikin.MedicinesAtHome.Integration.Medicines;
using Zzzaikin.MedicinesAtHome.Integration.Medicines.Configuration;

namespace Zzzaikin.MedicinesAtHome.Integration
{
    public class MedicinesIntegrator : IMedicinesIntegrator
    {
        private readonly IMedicinesIntegrationSource _medicinesIntegrationSource;

        private readonly MedicinesIntegrationConfiguration _medicinesIntegrationConfiguration;

        public MedicinesIntegrator(IMedicinesIntegrationSource medicinesIntegrationSource, 
            MedicinesIntegrationConfiguration medicinesIntegrationConfiguration) 
        {
            ZzzArgument.NotNull(medicinesIntegrationSource, nameof(medicinesIntegrationSource));
            ZzzArgument.NotNull(medicinesIntegrationConfiguration, nameof(medicinesIntegrationConfiguration));

            _medicinesIntegrationSource = medicinesIntegrationSource;
            _medicinesIntegrationConfiguration = medicinesIntegrationConfiguration;
        }

        public Task<IEnumerable<Medicine>> GetMedicinesTask()
        {
            return 
                _medicinesIntegrationSource
                    .GetMedicinesTask(_medicinesIntegrationConfiguration.MedicinesNamesAndLinksSourceUrl,
                        _medicinesIntegrationConfiguration.PathToMedicinesNamesAndLinksNodes);
        }
    }
}
