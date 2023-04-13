using Microsoft.EntityFrameworkCore;

namespace CTFOh.SQLManagement.Services;
using Data;
using DBContext;


public class ListChallsServices
{
    private CTFDBContext dbContext;

    public ListChallsServices(CTFDBContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<CTFListChalls>> GetListChallsAsync()
    {
        return await dbContext.CTFListChalls.ToListAsync();
    }

    public async Task<CTFListChalls> AddListChallsAsync(CTFListChalls lchalls)
    {
        try
        {
            dbContext.CTFListChalls.Add(lchalls);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }

        return lchalls;
    }

    public async Task<CTFListChalls> UpdateListChallsAsync(CTFListChalls lchalls)
    {
        try
        {
            var LChallsExist = dbContext.CTFListChalls.FirstOrDefault(l => l.Id == lchalls.Id);
            if (LChallsExist != null)
            {
                dbContext.Update(lchalls);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }

        return lchalls;
    }

    public async Task DeleteListChallsAsync(CTFListChalls lchalls)
    {
        try
        {
            dbContext.CTFListChalls.Remove(lchalls);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    
}