open Microsoft.AspNetCore.Builder
let builder = WebApplication.CreateBuilder()
let app = builder.Build()
app.Run()