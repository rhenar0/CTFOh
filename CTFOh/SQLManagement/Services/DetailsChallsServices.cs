using Microsoft.EntityFrameworkCore;

namespace CTFOh.SQLManagement.Services;
using Data;
using DBContext;


public class DetailsChallsServices
{
    private CTFDBContext dbContext;

    public DetailsChallsServices(CTFDBContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<CTFDetailsChalls>> GetDetailsChallsAsync()
    {
        return await dbContext.CTFDetailsChalls.ToListAsync();
    }

    public async Task<CTFDetailsChalls> AddDetailsChallsAsync(CTFDetailsChalls DChalls)
    {
        try
        {
            dbContext.CTFDetailsChalls.Add(DChalls);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }

        return DChalls;
    }

    public async Task<CTFDetailsChalls> UpdateDetailsChallsAsync(CTFDetailsChalls DChalls)
    {
        try
        {
            var DChallsExist = dbContext.CTFDetailsChalls.FirstOrDefault(l => l.Id == DChalls.Id);
            if (DChallsExist != null)
            {
                dbContext.Update(DChalls);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }

        return DChalls;
    }

    public async Task DeleteDetailsChallsAsync(CTFDetailsChalls DChalls)
    {
        try
        {
            dbContext.CTFDetailsChalls.Remove(DChalls);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    
}