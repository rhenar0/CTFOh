using Microsoft.EntityFrameworkCore;

namespace CTFOh.SQLManagement.Services;
using Data;
using DBContext;


public class UsersServices
{
    private CTFDBContext dbContext;

    public UsersServices(CTFDBContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<CTFUsers>> GetUsersAsync()
    {
        return await dbContext.CTFUsers.ToListAsync();
    }

    public async Task<CTFUsers> AddUsersAsync(CTFUsers users)
    {
        try
        {
            dbContext.CTFUsers.Add(users);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }

        return users;
    }

    public async Task<CTFUsers> UpdateUsersAsync(CTFUsers users)
    {
        try
        {
            var UsersExist = dbContext.CTFUsers.FirstOrDefault(l => l.Id == users.Id);
            if (UsersExist != null)
            {
                dbContext.Update(users);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }

        return users;
    }

    public async Task DeleteUsersAsync(CTFUsers users)
    {
        try
        {
            dbContext.CTFUsers.Remove(users);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    
}