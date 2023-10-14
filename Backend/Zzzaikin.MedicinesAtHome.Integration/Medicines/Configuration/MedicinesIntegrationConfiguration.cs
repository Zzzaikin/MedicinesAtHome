using ZzzArgument = Zzzaikin.Argument.Argument;

namespace Zzzaikin.MedicinesAtHome.Integration.Medicines.Configuration;

public class MedicinesIntegrationConfiguration
{
    public string MedicinesNamesAndLinksSourceUrl { get; private set; }

    public string PathToMedicinesNamesAndLinksNodes { get; private set;}

    public MedicinesIntegrationConfiguration(string medicinesNamesAndLinksSourceUrl, 
        string pathToMedicinesNamesAndLinksNodes)
    {
        ZzzArgument.NotNullOrEmpty(medicinesNamesAndLinksSourceUrl, nameof(medicinesNamesAndLinksSourceUrl));
        ZzzArgument.NotNullOrEmpty(pathToMedicinesNamesAndLinksNodes, nameof(pathToMedicinesNamesAndLinksNodes));

        MedicinesNamesAndLinksSourceUrl = medicinesNamesAndLinksSourceUrl;
        PathToMedicinesNamesAndLinksNodes = pathToMedicinesNamesAndLinksNodes;
    }    
}
