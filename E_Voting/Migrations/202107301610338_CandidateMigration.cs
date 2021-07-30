namespace E_Voting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidateMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        PoliticalPartyName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candidates");
        }
    }
}
