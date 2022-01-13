using System.Collections.Generic;
using System.Web.Mvc;

namespace RealEstateAgent.Web.Services
{
    public interface IDataTypeValueService
    {
        IEnumerable<SelectListItem> GetItemsFromValueListDataType(string dataTypeName,
            string[] selectedValues);
    }
}