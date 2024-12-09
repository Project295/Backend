using Project295.Core.Common;
using Project295.Core.Repository;
using Project295.Core.Services;
using Project295.Infra.Common;
using Project295.Infra.Repository;
using Project295.Infra.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDbContext, DbContext>();

builder.Services.AddScoped<IAttachmentRepository, AttachmentRepository>();
builder.Services.AddScoped<IAttachmentServices, AttachmentServices>();

builder.Services.AddScoped<IAttachmentTypeRepository, AttachmentTypeRepository>();
builder.Services.AddScoped<IAttachmentTypeServices, AttachmentTypeServices>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryServices, CategoryServices>();

builder.Services.AddScoped<IComplainRepository, ComplainRepository>();
builder.Services.AddScoped<IComplainServices, ComplainServices>();

builder.Services.AddScoped<IContactusRepository, ContactusRepository>();
builder.Services.AddScoped<IContactusServices, ContactusServices>();

builder.Services.AddScoped<IFollowerRepository, FollowerRepository>();
builder.Services.AddScoped<IFollowerServices, FollowerServices>();

builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<ILoginServices, LoginServices>();

builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPostServices, PostServices>();

builder.Services.AddScoped<IPostStatusRepository, PostStatusRepository>();
builder.Services.AddScoped<IPostStatusServices, PostStatusServices>();

builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<ISkillServices, SkillServices>();

builder.Services.AddScoped<ISkillsCategoryRepository, SkillsCategoryRepository>();
builder.Services.AddScoped<ISkillsCategoryServices, SkillsCategoryServices>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserServices, UserServices>();

builder.Services.AddScoped<IUserExperienceRepository, UserExperienceRepository>();
builder.Services.AddScoped<IUserExperienceServices, UserExperienceServices>();

builder.Services.AddScoped<IUserProjectRepository, UserProjectRepository>();
builder.Services.AddScoped<IUserProjectServices, UserProjectServices>();

builder.Services.AddScoped<IUserSkillRepository, UserSkillRepository>();
builder.Services.AddScoped<IUserSkillServices, UserSkillServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
