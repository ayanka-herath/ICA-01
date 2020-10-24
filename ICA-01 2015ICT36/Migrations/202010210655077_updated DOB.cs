namespace ICA_01_2015ICT36.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDOB : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Staff_tbl", name: "Branchno_Ref", newName: "Branch No");
            RenameIndex(table: "dbo.Staff_tbl", name: "IX_Branchno_Ref", newName: "IX_Branch No");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Staff_tbl", name: "IX_Branch No", newName: "IX_Branchno_Ref");
            RenameColumn(table: "dbo.Staff_tbl", name: "Branch No", newName: "Branchno_Ref");
        }
    }
}
