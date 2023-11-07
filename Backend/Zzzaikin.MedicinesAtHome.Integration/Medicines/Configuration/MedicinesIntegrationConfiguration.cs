using Zzzaikin.Common;

namespace Zzzaikin.MedicinesAtHome.Integration.Medicines.Configuration;

public class MedicinesIntegrationConfiguration
{
    public string MedicinesNamesAndLinksSourceUrl { get; private set; }

    public string PathToMedicinesNamesAndLinksNodes { get; private set;}

    public MedicinesIntegrationConfiguration(string medicinesNamesAndLinksSourceUrl, 
        string pathToMedicinesNamesAndLinksNodes)
    {
        Argument.NotNullOrEmpty(medicinesNamesAndLinksSourceUrl, nameof(medicinesNamesAndLinksSourceUrl));
        Argument.NotNullOrEmpty(pathToMedicinesNamesAndLinksNodes, nameof(pathToMedicinesNamesAndLinksNodes));

        MedicinesNamesAndLinksSourceUrl = medicinesNamesAndLinksSourceUrl;
        PathToMedicinesNamesAndLinksNodes = pathToMedicinesNamesAndLinksNodes;
    }    
}
