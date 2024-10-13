using Microsoft.EntityFrameworkCore;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.Contxt
{
    public class ShoopBaseContxt: DbContext
    {
        public ShoopBaseContxt(DbContextOptions<ShoopBaseContxt> options) : base(options)
        {

        }
        
        public virtual DbSet<T_AboutUs> T_AboutUs { get; set; }
        public virtual DbSet<T_Address> T_Address { get; set; }
        public virtual DbSet<T_Category> T_Category { get; set; }
        public virtual DbSet<T_City> T_City { get; set; }
        public virtual DbSet<T_Feedback> T_Feedback { get; set; }
        public virtual DbSet<T_Ganoon> T_Ganoon { get; set; }
        public virtual DbSet<T_ImagesProduct> T_ImagesProduct { get; set; }
        public virtual DbSet<T_Offer> T_Offer { get; set; }
        public virtual DbSet<T_Order> T_Order { get; set; }
        public virtual DbSet<T_Ostan> T_Ostan { get; set; }
        public virtual DbSet<T_Payment> T_Payment { get; set; }
        public virtual DbSet<T_Product> T_Product { get; set; }
        public virtual DbSet<T_SearchHistory> T_SearchHistory { get; set; }
        public virtual DbSet<T_SendEmail> T_SendEmail { get; set; }
        public virtual DbSet<T_ShoppingBasket> T_ShoppingBasket { get; set; }
        public virtual DbSet<T_TampOrder> T_TampOrder { get; set; }
        public virtual DbSet<T_TampShoppingBasket> T_TampShoppingBasket { get; set; }
        public virtual DbSet<T_User> T_User { get; set; }
        public virtual DbSet<T_LowOk> T_LowOk { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<T_Address>()
               .HasMany(e => e.T_Order)
               .WithOne(e => e.T_Address)
               .HasForeignKey(e => e.T_Address_Id)
               .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Address>()
                .HasMany(e => e.T_TampOrder)
                .WithOne(e => e.T_Address)
                .HasForeignKey(e => e.T_Address_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Category>()
                .HasMany(e => e.T_Product)
                .WithOne(e => e.T_Category)
                .HasForeignKey(e => e.T_Category_Id);

            modelBuilder.Entity<T_City>()
                .HasMany(e => e.T_Address)
                .WithOne(e => e.T_City)
                .HasForeignKey(e => e.T_City_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Ganoon>()
                .HasMany(e => e.T_LowOk)
                .WithOne(e => e.T_Ganoon)
                .HasForeignKey(e => e.T_Ganoon_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Order>()
                .HasMany(e => e.T_Payment)
                .WithOne(e => e.T_Order)
                .HasForeignKey(e => e.T_Order_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Order>()
                .HasMany(e => e.T_TampOrder)
                .WithOne(e => e.T_Order)
                .HasForeignKey(e => e.T_Order_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Ostan>()
                .HasMany(e => e.T_Address)
                .WithOne(e => e.T_Ostan)
                .HasForeignKey(e => e.T_Ostan_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Ostan>()
                .HasMany(e => e.T_City)
                .WithOne(e => e.T_Ostan)
                .HasForeignKey(e => e.T_Ostan_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<T_Product>()
                .HasMany(e => e.T_Feedback)
                .WithOne(e => e.T_Product)
                .HasForeignKey(e => e.ID_Product_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Product>()
                .HasMany(e => e.T_ImagesProduct)
                .WithOne(e => e.T_Product)
                .HasForeignKey(e => e.T_Product_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Product>()
                .HasMany(e => e.T_Offer)
                .WithOne(e => e.T_Product)
                .HasForeignKey(e => e.ID_Prodect_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Product>()
                .HasMany(e => e.T_ShoppingBasket)
                .WithOne(e => e.T_Product)
                .HasForeignKey(e => e.T_Product_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_Product>()
                .HasMany(e => e.T_TampShoppingBasket)
                .WithOne(e => e.T_Product)
                .HasForeignKey(e => e.T_Product_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_ShoppingBasket>()
                .Property(e => e.TotalPrice)
                .HasPrecision(29, 2);

            modelBuilder.Entity<T_ShoppingBasket>()
                .HasMany(e => e.T_TampShoppingBasket)
                .WithOne(e => e.T_ShoppingBasket)
                .HasForeignKey(e => e.T_ShoppingBasket_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_TampOrder>()
                .HasMany(e => e.T_TampShoppingBasket)
                .WithOne(e => e.T_TampOrder)
                .HasForeignKey(e => e.T_TampOrder_Id);

            modelBuilder.Entity<T_TampShoppingBasket>()
                .Property(e => e.IsActive)
                .IsRequired();

            modelBuilder.Entity<T_TampShoppingBasket>()
                .Property(e => e.TotalPrice)
                .HasPrecision(29, 2);

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_Address)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.T_User_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_Feedback)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.ID_UserSingup_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_LowOk)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.T_User_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_Order)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.T_User_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_Payment)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.ID_User_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_SearchHistory)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.T_User_Id);

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_SendEmail)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.T_User_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_ShoppingBasket)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.T_User_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_TampOrder)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.T_User_Id)
                .OnDelete(DeleteBehavior.Restrict);;

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_TampShoppingBasket)
                .WithOne(e => e.T_User)
                .HasForeignKey(e => e.T_User_Id)
                .OnDelete(DeleteBehavior.Restrict);;
        }
    }
}

