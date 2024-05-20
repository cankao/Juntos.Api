using AutoMapper;
using Juntos.Api.Users.App.ProfileMapper;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Input;

namespace Life.API.Proposal.App.Config
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile<UserProfile>();   
            });


            JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                MaxDepth = 10,
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true
            };

            serializerOptions.Converters.Add(new JsonStringEnumConverter());
            services.AddSingleton(serializerOptions);
            services.AddSingleton(mappingConfig.CreateMapper());

        }

    }
}
