namespace RadientHospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        patiendID = c.Int(nullable: false, identity: true),
                        patientName = c.String(),
                        patientDoB = c.DateTime(nullable: false),
                        gender = c.String(),
                        email = c.String(),
                        postcode = c.String(),
                        address = c.String(),
                        patientGpDetails_PatientGpDetailsId = c.Int(),
                    })
                .PrimaryKey(t => t.patiendID)
                .ForeignKey("dbo.PatientGpDetails", t => t.patientGpDetails_PatientGpDetailsId)
                .Index(t => t.patientGpDetails_PatientGpDetailsId);
            
            CreateTable(
                "dbo.PatientGpDetails",
                c => new
                    {
                        PatientGpDetailsId = c.Int(nullable: false, identity: true),
                        gpname = c.String(),
                        gpaddress = c.String(),
                    })
                .PrimaryKey(t => t.PatientGpDetailsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "patientGpDetails_PatientGpDetailsId", "dbo.PatientGpDetails");
            DropIndex("dbo.Patients", new[] { "patientGpDetails_PatientGpDetailsId" });
            DropTable("dbo.PatientGpDetails");
            DropTable("dbo.Patients");
        }
    }
}
