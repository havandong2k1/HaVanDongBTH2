// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace HaVanDongBTH2.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20221123050417_Create_Foreignkey_Student​")]
    partial class CreateForeignkeyStudent​
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("HaVanDongBTH2.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerAge")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("HaVanDongBTH2.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeAge")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("HaVanDongBTH2.Models.Faculty", b =>
                {
                    b.Property<string>("FacultyID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FacultyID");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("HaVanDongBTH2.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonAge")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("HaVanDongBTH2.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentAge")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.HasIndex("FacultyID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("HaVanDongBTH2.Models.Student", b =>
                {
                    b.HasOne("HaVanDongBTH2.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });
#pragma warning restore 612, 618
        }
    }
}
