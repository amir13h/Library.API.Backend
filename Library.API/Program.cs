using Library.API.DB;
using Library.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LibraryDB2>(Options=>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("mainDB"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapPost("/book/add",(LibraryDB2 db,Book book)=>
{
    db.Books.Add(book);
    db.SaveChanges();
});
app.MapPost("/book/list",(LibraryDB2 db)=>
{
    return db.Books.ToList();
});
app.MapPost("/book/update",(LibraryDB2 db,Book book)=>
{
    db.Books.Update(book);
    db.SaveChanges();
});
app.MapPost("/book/remove/{id}",(LibraryDB2 db,int id)=>
{
    var book=db.Books.Find(id);
    if (book!=null)
    {
        db.Books.Remove(book);
        db.SaveChanges();
    }
});
app.MapPost("/members/add", (LibraryDB2 db, Member member) =>
{
    db.Members.Add(member);
    db.SaveChanges();
});
app.MapGet("/members/list", (LibraryDB2 db) =>
{
    return db.Members.ToList();
});
app.MapPost("/members/update", (LibraryDB2 db, Member member) =>
{
    db.Members.Update(member);
    db.SaveChanges();
});
app.MapPost("/members/remove/{id}", (LibraryDB2 db, int id) =>
{
    var member = db.Members.Find(id);
    if (member != null)
    {
        db.Members.Remove(member);
        db.SaveChanges();
    }
});
app.MapPost("/rents/add", (LibraryDB2 db, Rent rent) =>
{
    db.Rents.Add(rent);
    db.SaveChanges();
});
app.MapGet("/rents/list", (LibraryDB2 db) =>
{
    return db.Rents.Include(m => m.Member).Include(b => b.Book).ToList();
});
app.MapPost("/rents/update", (LibraryDB2 db, Rent rent) =>
{
    db.Rents.Update(rent);
    db.SaveChanges();
});
app.MapPost("/rents/remove/{id}", (LibraryDB2 db, int id) =>
{
    var rent = db.Rents.Find(id);
    if (rent != null)
    {
        db.Rents.Remove(rent);
        db.SaveChanges();
    }
});
app.MapPost("/usernameandpassword/add",(LibraryDB2 db,UsernameAndPassword uap)=>
{
    db.UsernamesAndPasswords.Add(uap);
    db.SaveChanges();
});
app.MapGet("/usernameandpassword/list",(LibraryDB2 db)=>
{
    return db.UsernamesAndPasswords.ToList();
});
app.MapPost("/usernameandpassword/update",(LibraryDB2 db,UsernameAndPassword uap)=>
{
    db.UsernamesAndPasswords.Update(uap);
    db.SaveChanges();
});
app.MapPost("/usernameandpassword/remove/{id}",(LibraryDB2 db,int id)=>
{
    var uap=db.UsernamesAndPasswords.Find(id);
    if (uap!=null)
    {
    db.UsernamesAndPasswords.Remove(uap);
    db.SaveChanges(); 
    }
});
app.Run();
