namespace AppAdvocacia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Is", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Clientes", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
            DropColumn("dbo.Clientes", "Is");
        }
    }
}
