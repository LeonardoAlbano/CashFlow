using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

public class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflowdb;Uid=root;Pwd=Hety8a6yqe!;";

        var version = new Version(9,2,0);
        
        var serverVersion = new MySqlServerVersion(version);
        
        optionsBuilder.UseMySql(connectionString, serverVersion );
    }
}