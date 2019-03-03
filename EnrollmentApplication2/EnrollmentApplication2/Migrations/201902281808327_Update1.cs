namespace EnrollmentApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
			AddColumn("db.Enrollment", "Notes", c => c.String());
        }
        
        public override void Down()
        {
			DropColumn("db.Enrollment", "Notes");
        }
    }
}
