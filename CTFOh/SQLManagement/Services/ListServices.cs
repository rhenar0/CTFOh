using Microsoft.EntityFrameworkCore;

namespace CTFOh.SQLManagement.Services;
using Data;
using DBContext;

public interface IListServices
{
    Task<List<CTFList>> GetListAsync();
    Task<CTFList> AddListAsync(CTFList list);
    Task<CTFList> UpdateListAsync(CTFList list);
    Task DeleteListAsync(CTFList list);
}

public class ListServices : IListServices
{
    private CTFDBContext dbContext;

    public ListServices(CTFDBContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<CTFList>> GetListAsync()
    {
        return await dbContext.CTFList.ToListAsync();
    }

    public async Task<CTFList> AddListAsync(CTFList list)
    {
        try
        {
            dbContext.CTFList.Add(list);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }

        return list;
    }

    public async Task<CTFList> UpdateListAsync(CTFList list)
    {
        try
        {
            var ListExist = dbContext.CTFList.FirstOrDefault(l => l.Id == list.Id);
            if (ListExist != null)
            {
                dbContext.Update(list);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }

        return list;
    }

    public async Task DeleteListAsync(CTFList list)
    {
        try
        {
            dbContext.CTFList.Remove(list);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    
}