using System;

using Microsoft.Extensions.Configuration;

using R5T.Suebia.Extensions;


namespace R5T.Norsica.Configuration.Suebia
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddNuGetConfigurationJsonFile(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder.AddJsonSecretsFilePath(configurationServiceProvider, FileNames.NuGetConfigurationJsonFileName);

            return configurationBuilder;
        }
    }
}
