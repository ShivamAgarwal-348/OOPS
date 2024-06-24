
using Microsoft.Extensions.Configuration;
using OOPS.Patterns.OptionsPattern;

var configuration = new ConfigurationBuilder()
    .AddJsonFile(@"D:\Learning to Code\PluralSight - UKG\Object Oriented Design - C#\OOPS\OOPS\settings.json", false, true)
    .Build();

SampleSettings sampleSettings = new SampleSettings()
{
    StringSetting = configuration.GetSection(SampleSettings.SectionName)["StringSetting"],
    IntSetting = int.Parse(configuration.GetSection(SampleSettings.SectionName)["IntSetting"])
};

SettingsLogger settingsLogger = new SettingsLogger(sampleSettings);

settingsLogger.Log();