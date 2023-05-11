using Microsoft.EntityFrameworkCore;

namespace EFCoreTestsConsoleApp1;

public class Person
{
    public Guid Id { get; set; }

    public Info? Info { get; set; }

    public List<Account> Accounts { get; set; } = new();
}

public class Info
{
    public Guid Id { get; set; }

    public string? First { get; set; }
    public string? Last { get; set; }

    public Guid PersonId { get; set; }
    public Person Person { get; set; } = null!;
}

public class Account
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public Guid PersonId { get; set; }
    public Person Person { get; set; } = null!;
}

public static class Conf
{
    public static void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True;");
    }

    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasKey(x => x.Id);
        modelBuilder.Entity<Person>()
            .HasOne(x => x.Info)
            .WithOne(x => x.Person)
            .HasForeignKey<Info>(x => x.PersonId)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Person>()
            .HasMany(x => x.Accounts)
            .WithOne(x => x.Person)
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Info>()
            .HasKey(x => x.Id);
    }
}


public class SchoolContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Info> Infos { get; set; }
    public DbSet<Account> Accounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Conf.OnConfiguring(optionsBuilder);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Conf.OnModelCreating(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
}

public class SchoolContextNT : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Info> Infos { get; set; }
    public DbSet<Account> Accounts { get; set; }

    public SchoolContextNT()
    {
        ChangeTracker.AutoDetectChangesEnabled = false;
        ChangeTracker.LazyLoadingEnabled = false;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Conf.OnConfiguring(optionsBuilder);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Conf.OnModelCreating(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
}