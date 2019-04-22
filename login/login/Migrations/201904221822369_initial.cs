namespace login.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especialidade",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EspecialidadeNome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CRM = c.String(nullable: false),
                        Nome = c.String(nullable: false),
                        Endereco = c.String(nullable: false, maxLength: 150),
                        Bairro = c.String(nullable: false),
                        Cidade = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                        Pais = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        AtendePorConvenio = c.Boolean(nullable: false),
                        TemClinica = c.Boolean(nullable: false),
                        WebsiteBlog = c.String(),
                        EspecialidadeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Especialidade", t => t.EspecialidadeID, cascadeDelete: true)
                .Index(t => t.EspecialidadeID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Login = c.String(nullable: false, maxLength: 30),
                        Senha = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "EspecialidadeID", "dbo.Especialidade");
            DropIndex("dbo.Medico", new[] { "EspecialidadeID" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Medico");
            DropTable("dbo.Especialidade");
        }
    }
}
