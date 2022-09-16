using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TolgaESoftware.StudentTracking.Data.StudentTrackingMigration;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Data.Contexts
{
    public class StudentTrackingContext : BaseDbContext<StudentTrackingContext,Configuration>
    {
       
        public StudentTrackingContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public StudentTrackingContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Province>().HasMany(p=>p.District).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Bank>().HasMany(p=>p.BankBranch).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Discount>().HasMany(p=>p.DiscountApplyServices).WithRequired().WillCascadeOnDelete(true);
        }

        public DbSet<Province> Province { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Filter> Filter { get; set; }
        public DbSet<FamilyInfo> FamilyInfo { get; set; }
        public DbSet<CancellationReason> CancellationReason { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguage { get; set; }
        public DbSet<Incent> Incent { get; set; }
        public DbSet<Quota> Quota { get; set; }
        public DbSet<Guide> Guide { get; set; }
        public DbSet<ClassGroup> ClassGroup { get; set; }
        public DbSet<Vocation> Vocations { get; set; }
        public DbSet<Kinship> Kinship { get; set; }
        public DbSet<Workplace> Workplace { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<DiscountType> DiscountType { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Term> Term { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<SchoolBus> SchoolBus { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<ServiceType> ServiceType { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<SpecialCode> SpecialCode { get; set; }
        public DbSet<Vault> Vault { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BankBranch> BankBranch { get; set; }
        public DbSet<Lawyer> Lawyer { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<DiscountApplyServices> DiscountApplyServices { get; set; }
        public DbSet<Accrue> Accrue { get; set; }
        public DbSet<SiblingInformations> SiblingInformations { get; set; }
        public DbSet<FamilyInformations> FamilyInformations { get; set; }
        public DbSet<ExamInformations> ExamInformations { get; set; }
        public DbSet<DocumentInformations> DocumentInformations { get; set; }
        public DbSet<PromotionInformations> PromotionInformations { get; set; }
        public DbSet<ContactInformations> ContactInformations { get; set; }
        public DbSet<EposInformations> EposInformations { get; set; }
        public DbSet<NoteInformations> NoteInformations { get; set; }
        public DbSet<ServiceInformations> ServiceInformations { get; set; }
        public DbSet<DiscountInformations> DiscountInformations { get; set; }
        public DbSet<PaymentInformations> PaymentInformations { get; set; }
        public DbSet<RefundInformations> RefundInformations { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<ReceiptActions> ReceiptActions { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<OverdueStatements> OverdueStatements { get; set; }
        public DbSet<TermParameter> TermParameter { get; set; }
        public DbSet<UserParameter> UserParameter { get; set; }
        public DbSet<EmailParameter> EmailParameter { get; set; }
        public DbSet<InstitutionInformations> InstitutionInformations { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleAuthorizations> RoleAuthorizations { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserUnitAuthorizations> UserUnitAuthorizations { get; set; }
    }
}