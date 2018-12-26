using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HTCMobile.Localization
{
    public static class HTCMobileLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HTCMobileConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HTCMobileLocalizationConfigurer).GetAssembly(),
                        "HTCMobile.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
