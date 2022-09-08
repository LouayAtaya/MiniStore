using MiniStore.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Features;
using Volo.Abp.Localization;
using Volo.Abp.Validation.StringValues;

namespace MiniStore
{
    public class MiniStoreFeatureDefinitionProvider : FeatureDefinitionProvider
    {
        public override void Define(IFeatureDefinitionContext context)
        {
            var myGroup = context.AddGroup("MiniStore");

            myGroup.AddFeature(
                "MiniStore.MaxItemsCount",
                defaultValue: "10",
                displayName: L("MaxItemsCount"),
                valueType: new FreeTextStringValueType(
                               new NumericValueValidator(0, 1000000))
            );
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MiniStoreResource>(name);
        }
    }
}
