namespace AssignmentCodeFirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New_Addition : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stud_Details",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Stud_Branch = c.String(),
                        Stud_City = c.String(),
                        Stud_Percentage = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stud_Details");
        }
    }
}
