using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShopppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Phones" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Laptops" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Dresses" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Shoes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Jackets" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Assorted Phones",
                Price = 4.95M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                CategoryId = 1,
                ImageUrl="\\Images\\phone1.jpg",
                ImageThumbnailUrl= "\\Images\\thumbnails\\phone1-small.jpg",
                IsInStock=true,
                IsOnSale=false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Another Assorted Phones",
                Price = 3.95M,
                Description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                CategoryId = 1,
                ImageUrl = "\\Images\\phone2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\phone2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
           //modelBuilder.Entity<Product>().HasData(new Product
           //{
           //    ProductId = 3,
           //    Name = "Another Phones",
           //    Price = 5.75M,
           //    Description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
           //    CategoryId = 1,
           //    ImageUrl = "\\Images\\phone13.jpg",
           //    ImageThumbnailUrl = "\\Images\\thumbnails\\phone13-small.jpg",
           //    IsInStock = true,
           //    IsOnSale = false
           //});
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Assorted Laptops",
                Price = 3.95M,
                Description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                CategoryId = 2,
                ImageUrl = "\\Images\\laptop1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\laptop1-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Laptops",
                Price = 7.00M,
                Description = "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.",
                CategoryId = 2,
                ImageUrl = "\\Images\\laptop2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\laptop2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            //modelBuilder.Entity<Product>().HasData(new Product
            //{
            //    ProductId = 6,
            //    Name = "Another Assorted Laptops",
            //    Price = 11.25M,
            //    Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
            //    CategoryId = 2,
            //    ImageUrl = "\\Images\\laptop13.jpg",
            //    ImageThumbnailUrl = "\\Images\\thumbnails\\laptop13-small.jpg",
            //    IsInStock = true,
            //    IsOnSale = true
            //});
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Assorted Dresses",
                Price = 3.95M,
                Description = "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.",
                CategoryId = 3,
                ImageUrl = "\\Images\\dress1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\dress1-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Another Assorted Dresses",
                Price = 1.95M,
                Description = "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.",
                CategoryId = 3,
                ImageUrl = "\\Images\\dress2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\dress2-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            //modelBuilder.Entity<Product>().HasData(new Product
            //{
            //    ProductId = 9,
            //    Name = "Dresses",
            //    Price = 13.95M,
            //    Description = "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.",
            //    CategoryId = 3,
            //    ImageUrl = "\\Images\\dress13.jpg",
            //    ImageThumbnailUrl = "\\Images\\thumbnails\\dress13-small.jpg",
            //    IsInStock = true,
            //    IsOnSale = false
            //});
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Shoes",
                Price = 1.95M,
                Description = "Vitae congue eu consequat ac felis donec et odio. Tellus orci ac auctor augue mauris augue. Feugiat sed lectus vestibulum mattis ullamcorper velit sed. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Sed pulvinar proin gravida hendrerit lectus a.",
                CategoryId = 4,
                ImageUrl = "\\Images\\shoe1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\shoe1-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Assorted Shoes",
                Price = 12.95M,
                Description = "Hac habitasse platea dictumst quisque sagittis purus sit. Dui nunc mattis enim ut. Mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                CategoryId = 4,
                ImageUrl = "\\Images\\shoe2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\shoe2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            // modelBuilder.Entity<Product>().HasData(new Product
            // {
            //     ProductId = 12,
            //     Name = "Another Shoes",
            //     Price = 21.95M,
            //     Description = "Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Vulputate eu scelerisque felis imperdiet proin fermentum.",
            //     CategoryId = 4,
            //     ImageUrl = "\\Images\\shoe13.jpg",
            //     ImageThumbnailUrl = "\\Images\\thumbnails\\shoe13-small.jpg",
            //     IsInStock = true,
            //     IsOnSale = true
            // });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Jackets",
                Price = 6.95M,
                Description = "Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Arcu cursus euismod quis viverra.",
                CategoryId = 5,
                ImageUrl = "\\Images\\jacket1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\jacket1-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Another Jackets",
                Price = 2.95M,
                Description = "Blandit massa enim nec dui nunc mattis enim ut tellus. Duis at consectetur lorem donec massa sapien faucibus et. At auctor urna nunc id cursus metus. Ut enim blandit volutpat maecenas volutpat blandit.",
                CategoryId = 5,
                ImageUrl = "\\Images\\jacket2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\jacket2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            //modelBuilder.Entity<Product>().HasData(new Product
            //{
            //    ProductId = 15,
            //    Name = "Best Jackets",
            //    Price = 16.95M,
            //    Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
            //    CategoryId = 5,
            //    ImageUrl = "\\Images\\jacket13.jpg",
            //    ImageThumbnailUrl = "\\Images\\thumbnails\\jacket13-small.jpg",
            //    IsInStock = true,
            //    IsOnSale = false
            //});
        }
    }
}
