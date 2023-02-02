using System.Reflection;
using System.Runtime.CompilerServices;
using GraphQL;
using GraphQL.Server.Ui.Playground;
using GraphQLFirst.AppContext;
using GraphQLFirst.Contracts;
using GraphQLFirst.GraphQL.GraphQLQueries;
using GraphQLFirst.GraphQL.GraphQLSchema;
using GraphQLFirst.Repository;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistence(builder.Configuration);

builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();

builder.Services.AddScoped<AppQuery>();
builder.Services.AddScoped<AppSchema>();

builder.Services.AddGraphQL(builder => builder
    .AddSystemTextJson()
    .AddAutoSchema<AppSchema>()
    .AddGraphTypes()
    .AddDataLoader());


builder.Services.AddControllers()
    .AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.AllowSynchronousIO = true;
});

var app = builder.Build();
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseGraphQL<AppSchema>();
app.UseGraphQLPlayground(options: new PlaygroundOptions());

app.Run();
