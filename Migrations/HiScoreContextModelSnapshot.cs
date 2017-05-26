using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using webapiplayground.Models;

namespace webapiplayground.Migrations
{
    [DbContext(typeof(HiScoreContext))]
    partial class HiScoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webapiplayground.Models.Score", b =>
                {
                    b.Property<string>("Player")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("score");

                    b.HasKey("Player");

                    b.ToTable("Score");
                });
        }
    }
}
