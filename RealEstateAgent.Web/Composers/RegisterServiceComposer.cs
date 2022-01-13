using RealEstateAgent.Web.Services;
using RealEstateAgent.Web.Services.Logic;
using Searching.Site.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace RealEstateAgent.Web.Composers
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class RegisterServiceComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISearchService, SearchService>(Lifetime.Request);
            composition.Register(typeof(IDataTypeValueService), typeof(DataTypeValueService), Lifetime.Request);
        }
    }
}