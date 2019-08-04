using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StartUp.Confluence.Model.Entities.Accounts;
using StartUp.Confluence.Model.Entities.Confluence;
using StartUp.Confluence.Model.Entities.Spaces;
using System.Collections.Generic;

namespace StartUp.Confluence.Model
{
  public class ConfluenceDBContext : DbContext
  {
    public ConfluenceDBContext(DbContextOptions<ConfluenceDBContext> options)
        : base(options)
    { }

    public DbSet<AccountAudit> AccountAudits { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountType> AccountTypes { get; set; }
    public DbSet<AddressBook> AddressBooks { get; set; }
    public DbSet<ContactAudit> ContactAudits { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Industry> Industries { get; set; }

    public DbSet<Space> Spaces { get; set; }
    public DbSet<Content> Contents { get; set; }

    public DbSet<Category> Categories { get; set; }  
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionChoice> QuestionChoices { get; set; }
    public DbSet<UserQuestionAnswer> UserQuestionAnswers { get; set; }


    public override int SaveChanges()
    {
      return base.SaveChanges();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.RemovePluralizingTableNameConvention();

      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Category>()
                  .HasOne(x => x.Parent)
                  .WithMany(x => x.Children)
                  .HasForeignKey(x => x.ParentId);
    }
  }

  public static class ModelBuilderExtensions
  {
    public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
    {
      foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
      {
        entity.Relational().TableName = entity.DisplayName();
      }
    }
  }
}

