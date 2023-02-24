using System;


namespace TRPONEW.Data
  {
    public class ApplicationDbContextDbContext : IdentityDbContext
    {
        public ApplicationDbContextDbContext(DbContextOptions<ApplicationDbContextDbContext> options)
            : base(options);


    }


   }