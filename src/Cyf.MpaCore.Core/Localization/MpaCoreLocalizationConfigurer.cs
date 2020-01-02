using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Cyf.MpaCore.Localization
{
    public static class MpaCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MpaCoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MpaCoreLocalizationConfigurer).GetAssembly(),
                        "Cyf.MpaCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
