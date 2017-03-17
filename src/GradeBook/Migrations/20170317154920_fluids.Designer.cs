using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GradeBook.Data;

namespace GradeBook.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170317154920_fluids")]
    partial class fluids
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GradeBook.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("AdminRegister");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("GradeLevel");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GradeBook.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssignmentGrade");

                    b.Property<int>("ClassID");

                    b.Property<string>("ClassWork");

                    b.Property<string>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("ClassID");

                    b.HasIndex("StudentId");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("GradeBook.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Subject");

                    b.Property<string>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("GradeBook.Models.Clubs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClubName");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("GradeBook.Models.StudentClass", b =>
                {
                    b.Property<string>("StudentId");

                    b.Property<int>("SubjectId");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentClass");
                });

            modelBuilder.Entity("GradeBook.Models.StudentClub", b =>
                {
                    b.Property<string>("StudentId");

                    b.Property<int>("ClubId");

                    b.HasKey("StudentId", "ClubId");

                    b.HasIndex("ClubId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentClub");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GradeBook.Models.Assignment", b =>
                {
                    b.HasOne("GradeBook.Models.Class", "Course")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GradeBook.Models.ApplicationUser", "Student")
                        .WithMany("Assignment")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("GradeBook.Models.Class", b =>
                {
                    b.HasOne("GradeBook.Models.ApplicationUser", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("GradeBook.Models.StudentClass", b =>
                {
                    b.HasOne("GradeBook.Models.ApplicationUser", "Student")
                        .WithMany("StudentClass")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GradeBook.Models.Class", "Subject")
                        .WithMany("StudentClass")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GradeBook.Models.StudentClub", b =>
                {
                    b.HasOne("GradeBook.Models.Clubs", "ClubName")
                        .WithMany("StudentClub")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GradeBook.Models.ApplicationUser", "Student")
                        .WithMany("StudentClub")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GradeBook.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GradeBook.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GradeBook.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
