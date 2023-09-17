using Zzzaikin.MedicinesAtHome.Models;
using ZzzArgument = Zzzaikin.Argument.Argument;
using Zzzaikin.MedicinesAtHome.Integration.Medicines;

namespace Zzzaikin.MedicinesAtHome.Integration
{
    public class MedicinesIntegrator : IMedicinesIntegrator
    {
        private readonly IMedicinesIntegrationParser _medicinesIntegrationParser;

        public MedicinesIntegrator(IMedicinesIntegrationParser medicinesIntegrationParser) 
        {
            ZzzArgument.NotNull(medicinesIntegrationParser, nameof(medicinesIntegrationParser));
            _medicinesIntegrationParser = medicinesIntegrationParser;
        }

        public Task<IEnumerable<Medicine>> GetMedicinesTask()
        {
            var medicinesNames =  _medicinesIntegrationParser.GetMedicinesNamesTask();
            return _medicinesIntegrationParser.GetMedicinesFullInfoTask(medicinesNames);
        }
    }
}
