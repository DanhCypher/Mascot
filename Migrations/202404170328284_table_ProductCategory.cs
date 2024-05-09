namespace BanHangThoiTrangMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_ProductCategory : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Order", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Order", "CustomerId", c => c.String());
        }
    }
}
