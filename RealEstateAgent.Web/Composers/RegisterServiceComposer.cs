using RealEstateAgent.Web.Services;
using RealEstateAgent.Web.Services.Logic;
using Searching.Site.Services;
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

            composition.Components().Append<RegisterSettingsComponent>();
        }
    }
}