using HtmlAgilityPack;
using Zzzaikin.MedicinesAtHome.Models;
using ZzzArgument = Zzzaikin.Argument.Argument;
using Zzzaikin.MedicinesAtHome.Integration.Medicines;

namespace Zzzaikin.MedicinesAtHome.Integration
{
    public class PharmacyMedsiParser: IMedicinesIntegrationSource
    {
        private readonly HtmlWeb _htmlWeb;

        public PharmacyMedsiParser() 
        {
            _htmlWeb = new HtmlWeb();
        }

        public async Task<IEnumerable<Medicine>> GetMedicinesTask(string medicinesNamesAndLinksUrl,
            string pathToMedicinesNamesAndLinksNodes)
        {
            ZzzArgument.NotNullOrEmpty(medicinesNamesAndLinksUrl, nameof(medicinesNamesAndLinksUrl));
            ZzzArgument.NotNullOrEmpty(pathToMedicinesNamesAndLinksNodes, nameof(pathToMedicinesNamesAndLinksNodes));

            var document = await GetDocumentAsync(medicinesNamesAndLinksUrl);

            var medicinesNamesAndUrisAsync = 
                await GetMedicinesNamesAndUrisAsync(document, pathToMedicinesNamesAndLinksNodes);
            
        }

        private async Task<Dictionary<string, Uri>> GetMedicinesNamesAndUrisAsync(HtmlDocument document, 
            string pathToMedicinesNamesAndLinksNodes)
        {
            var medicinesNodes = document.DocumentNode.SelectNodes(pathToMedicinesNamesAndLinksNodes);
        }

        private async Task<HtmlDocument> GetDocumentAsync(string url) 
        {
            return await _htmlWeb.LoadFromWebAsync(url);
        }
    }
}
