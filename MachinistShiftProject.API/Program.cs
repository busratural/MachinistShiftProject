using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.Business.Concrate;
using MachinistShiftProject.Business.Concrete;
using MachinistShiftProject.DataAccess;
using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.DataAccess.Abstract;
using MachinistShiftProject.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using StaffShiftProject.Business.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddDbContext<MachinistShiftDbContext>();
//builder.Services.AddHttpClient();
builder.Services.AddScoped<IMachinistService, MachinistManager>();
builder.Services.AddScoped<IMachinistReadRepository, MachinistReadRepository>();
builder.Services.AddScoped<IMachinistWriteRepository, MachinistWriteRepository>();

builder.Services.AddScoped<IExpeditionService, ExpeditionManager>();
builder.Services.AddScoped<IExpeditionReadRepository, ExpeditionReadRepository>();
builder.Services.AddScoped<IExpeditionWriteRepository, ExpeditionWriteRepository>();

builder.Services.AddScoped<ITaskTitleService, TaskTitleManager>();
builder.Services.AddScoped<ITaskTitleReadRepository, TaskTitleReadRepository>();
builder.Services.AddScoped<ITaskTitleWriteRepository, TaskTitleWriteRepository>();

builder.Services.AddScoped<ITaskDefinitonService, TaskDefinitonManager>();
builder.Services.AddScoped<ITaskDefinitionReadRepository, TaskDefinitionReadRepository>();
builder.Services.AddScoped<ITaskDefinitionWriteRepository, TaskDefinitionWriteRepository>();


builder.Services.AddScoped<ITitleService, TitleManager>();
builder.Services.AddScoped<ITitleReadRepository, TitleReadRepository>();
builder.Services.AddScoped<ITitleWriteRepository, TitleWriteRepository>();

builder.Services.AddScoped<IStaffService, StaffManager>();
builder.Services.AddScoped<IStaffReadRepository,  StaffReadRepository>();
builder.Services.AddScoped<IStaffWriteRepository, StaffWriteRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapRazorPages();
app.MapControllers();
app.Run();
