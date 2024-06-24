using YarnRecipees.Service.Repository;
using YarnRecipees.Service.Query;
using YarnRecipees.Service.Repository;
using YarnRecipees.Service.Repository.Recipe;
using YarnRecipees.Service.Repository.Yarns;
using YarnRecipees.Service.SchemaTypes;

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.json
var connectionString = builder.Configuration.GetSection("ConnectionString").Value;

builder.Services
    .AddScoped<DbConnection>(sp =>
        new DbConnection(connectionString));

builder.Services.AddScoped<YarnRepository>().AddScoped<RecipeRepository>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Yarn>()
    .AddType<Recipe>();

var app = builder.Build();

app.Use(async (context, next) =>
{
    if (context.Request.Path.Value == "/")
    {
        context.Response.Redirect("/graphql");
    }
    else
    {
        await next.Invoke();
    }
});

app.UseRouting().UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();