using Microsoft.EntityFrameworkCore;

namespace CTFOh.SQLManagement.Services;
using Data;
using DBContext;


public class TeamsServices
{
    private CTFDBContext dbContext;

    public TeamsServices(CTFDBContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<CTFTeams>> GetTeamsAsync()
    {
        return await dbContext.CTFTeams.ToListAsync();
    }

    public async Task<CTFTeams> AddTeamsAsync(CTFTeams teams)
    {
        try
        {
            dbContext.CTFTeams.Add(teams);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }

        return teams;
    }

    public async Task<CTFTeams> UpdateTeamsAsync(CTFTeams teams)
    {
        try
        {
            var TeamsExist = dbContext.CTFTeams.FirstOrDefault(l => l.Id == teams.Id);
            if (TeamsExist != null)
            {
                dbContext.Update(teams);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }

        return teams;
    }

    public async Task DeleteTeamsAsync(CTFTeams teams)
    {
        try
        {
            dbContext.CTFTeams.Remove(teams);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    
}