﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(BookHubDBContext))]
    partial class BookHubDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("DataAccessLayer.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "George Orwell"
                        },
                        new
                        {
                            Id = 2,
                            Name = "J.K. Rowling"
                        },
                        new
                        {
                            Id = 3,
                            Name = "J.R.R. Tolkien"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Agatha Christie"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Stephen King"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("PublisherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949",
                            GenreId = 1,
                            Price = 15.99m,
                            PublisherId = 1,
                            Title = "1984"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling.",
                            GenreId = 2,
                            Price = 20.99m,
                            PublisherId = 2,
                            Title = "Harry Potter and the Philosopher's Stone"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Description = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien.",
                            GenreId = 3,
                            Price = 25.99m,
                            PublisherId = 3,
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            Description = "Murder on the Orient Express is a detective novel by English writer Agatha Christie.",
                            GenreId = 4,
                            Price = 18.99m,
                            PublisherId = 4,
                            Title = "Murder on the Orient Express"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            Description = "The Shining is a horror novel by American author Stephen King.",
                            GenreId = 5,
                            Price = 22.99m,
                            PublisherId = 5,
                            Title = "The Shining"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "password123",
                            Username = "Janko"
                        },
                        new
                        {
                            Id = 2,
                            Password = "annaBsecure456",
                            Username = "AnnaB"
                        },
                        new
                        {
                            Id = 3,
                            Password = "mikeWpassword789",
                            Username = "MikeW"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Horror"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Penguin Books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bloomsbury"
                        },
                        new
                        {
                            Id = 3,
                            Name = "HarperCollins"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Simon & Schuster"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Scholastic"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.PurchaseHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("PurchaseHistories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CustomerId = 1,
                            PurchaseDate = new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            BookId = 3,
                            CustomerId = 1,
                            PurchaseDate = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            BookId = 4,
                            CustomerId = 2,
                            PurchaseDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            BookId = 5,
                            CustomerId = 3,
                            PurchaseDate = new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Comment = "Very nice book!",
                            CustomerId = 1,
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            BookId = 3,
                            Comment = "Worst book!",
                            CustomerId = 1,
                            Rating = 1
                        },
                        new
                        {
                            Id = 3,
                            BookId = 4,
                            Comment = "Intriguing and thrilling!",
                            CustomerId = 2,
                            Rating = 4
                        },
                        new
                        {
                            Id = 4,
                            BookId = 5,
                            Comment = "Scary but a bit too long.",
                            CustomerId = 3,
                            Rating = 3
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Wishlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Wishlists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 2,
                            CustomerId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 4,
                            CustomerId = 2
                        },
                        new
                        {
                            Id = 3,
                            BookId = 5,
                            CustomerId = 3
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Book", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("DataAccessLayer.Models.PurchaseHistory", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Book", "Book")
                        .WithMany("PurchaseHistories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.Customer", "Customer")
                        .WithMany("PurchaseHistories")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Review", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Wishlist", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Book", "Book")
                        .WithMany("Wishlists")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.Customer", "Customer")
                        .WithMany("Wishlists")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Book", b =>
                {
                    b.Navigation("PurchaseHistories");

                    b.Navigation("Reviews");

                    b.Navigation("Wishlists");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Customer", b =>
                {
                    b.Navigation("PurchaseHistories");

                    b.Navigation("Reviews");

                    b.Navigation("Wishlists");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
