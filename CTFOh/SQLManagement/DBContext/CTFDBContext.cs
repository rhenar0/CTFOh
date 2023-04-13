namespace CTFOh.SQLManagement.DBContext;
using Data;
using Microsoft.EntityFrameworkCore;

public class CTFDBContext : DbContext
{
    public CTFDBContext(DbContextOptions<CTFDBContext> options) : base(options)
    {
        
    }
    
    public DbSet<CTFList> CTFList { get; set; }
    public DbSet<CTFUsers> CTFUsers { get; set; }
    public DbSet<CTFTeams> CTFTeams { get; set; }
    public DbSet<CTFListChalls> CTFListChalls { get; set; }
    public DbSet<CTFDetailsChalls> CTFDetailsChalls { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CTFList>().HasData(GetCTFList());
        modelBuilder.Entity<CTFUsers>().HasData(GetCTFUsers());
        modelBuilder.Entity<CTFTeams>().HasData(GetCTFTeams());
        modelBuilder.Entity<CTFListChalls>().HasData(GetCTFListChalls());
        modelBuilder.Entity<CTFDetailsChalls>().HasData(GetCTFDetailsChalls());
        base.OnModelCreating(modelBuilder);
    }

    private List<CTFList> GetCTFList()
    {
        return new List<CTFList>
        {
            new CTFList
            {
                Id = 1, Name = "CTFTest", Dstart = "29/05/2023 13:00:00", Dend = "29/05/2023 15:00:00", Select = 1
            },
            new CTFList
            {
                Id = 2, Name = "CTFToust", Dstart = "21/05/2023 13:00:00", Dend = "24/05/2023 15:00:00", Select = 0
            }
        };
    }
    
    private List<CTFUsers> GetCTFUsers()
    {
        return new List<CTFUsers>
        {
            new CTFUsers
            {
                Id = 1, Pseudo = "Rhenar", ChkPassword = "068d23b4c3e5ba01291aef534de6e058", Team = 1, Score = 2300,
                AssignedChalls = "{1, 2, 4}", LinkedCTF = 1
            },
            new CTFUsers
            {
                Id = 2, Pseudo = "Hope", ChkPassword = "068d23b4c3e5ba01291aef534de6e058", Team = 1, Score = 2500,
                AssignedChalls = "{1, 4, 5}", LinkedCTF = 1
            },
            new CTFUsers
            {
                Id = 3, Pseudo = "Segrard", ChkPassword = "068d23b4c3e5ba01291aef534de6e058", Team = 2, Score = 230,
                AssignedChalls = "{1, 2, 3}", LinkedCTF = 1
            },
            new CTFUsers
            {
                Id = 4, Pseudo = "Segrard", ChkPassword = "068d23b4c3e5ba01291aef534de6e058", Team = 2, Score = 230,
                AssignedChalls = "{1, 2, 3}", LinkedCTF = 2
            }
        };
    }
    
    private List<CTFTeams> GetCTFTeams()
    {
        return new List<CTFTeams>
        {
            new CTFTeams
            {
                Id = 1, Name = "BlueProject", ChkPassword = "068d23b4c3e5ba01291aef534de6e058",
                NiceChalls = "{1, 2, 4}", LinkedCTF = 1
            },
            new CTFTeams
            {
                Id = 2, Name = "OteriHack", ChkPassword = "068d23b4c3e5ba01291aef534de6e058",
                NiceChalls = "{4, 2, 3}", LinkedCTF = 1
            },
        };
    }

    private List<CTFListChalls> GetCTFListChalls()
    {
        return new List<CTFListChalls>
        {
            new CTFListChalls
            {
                Id = 1, Name = "Je Bouh", Actif = 1, Chall = "{1, 2, 4}", Order = "{1, 2, 4}", StrictOrder = 1, LinkedCTF = 1
            },
            new CTFListChalls
            {
                Id = 2, Name = "JeBoude", Actif = 1, Chall = "{3}", Order = "{3}", StrictOrder = 0, LinkedCTF = 1
            },
            new CTFListChalls
            {
                Id = 3, Name = "Bouhbouh", Actif = 1, Chall = "{5}", Order = "{5}", StrictOrder = 0, LinkedCTF = 1
            },
            new CTFListChalls
            {
                Id = 4, Name = "Pasla", Actif = 0, Chall = "{6}", Order = "{6}", StrictOrder = 0, LinkedCTF = 1
            },
            new CTFListChalls
            {
                Id = 5, Name = "Pasla", Actif = 0, Chall = "{6}", Order = "{6}", StrictOrder = 0, LinkedCTF = 2
            }
        };
    }
    
    private List<CTFDetailsChalls> GetCTFDetailsChalls()
    {
        return new List<CTFDetailsChalls>
        {
            new CTFDetailsChalls
            {
                Id = 1, Points = 100, Name = "Bouh", Desc = "Je Bouh", Img = "{\"null\"}",
                Files = "{\"https://boubouh.txt/text.png\"}", Links = "{\"null\"}", Actif = 1, LinkedCTF = 1
            },
            new CTFDetailsChalls
            {
                Id = 2, Points = 240, Name = "Bouhda", Desc = "Je Bouh", Img = "{\"https://boubouh.txt/text.png\"}",
                Files = "{\"https://boubouh.txt/text.png\"}", Links = "{\"null\"}", Actif = 1, LinkedCTF = 1
            },
            new CTFDetailsChalls
            {
                Id = 3, Points = 10, Name = "Bouher", Desc = "Je Bouh", Img = "{\"null\"}",
                Files = "{\"https://boubouh.txt/text.png\"}", Links = "{\"null\"}", Actif = 1, LinkedCTF = 1
            },
            new CTFDetailsChalls
            {
                Id = 4, Points = 260, Name = "Bouhas", Desc = "Je Bouh", Img = "{\"null\"}",
                Files = "{\"https://boubouh.txt/text.png\"}", Links = "{\"https://boubouh.txt/text.png\"}", Actif = 1, LinkedCTF = 1
            },
            new CTFDetailsChalls
            {
                Id = 5, Points = 2000, Name = "Bouhvi", Desc = "Je Bouh", Img = "{\"null\"}",
                Files = "{\"https://boubouh.txt/text.png\"}", Links = "{\"null\"}", Actif = 1, LinkedCTF = 1
            },
            new CTFDetailsChalls
            {
                Id = 6, Points = 30, Name = "Bouhtu", Desc = "Je Bouh", Img = "{\"null\"}",
                Files = "{\"https://boubouh.txt/text.png\"}", Links = "{\"null\"}", Actif = 0, LinkedCTF = 1
            }
        };
    }
    
}