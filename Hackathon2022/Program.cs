var builder = WebApplication.CreateBuilder(args);

// ��������� � ���������� ������� Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// ��������� ��������� ������������� ��� Razor Pages
app.MapRazorPages();
app.UseStaticFiles();

app.Run();