using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using webapiplayground.Models;

namespace webapiplayground.Migrations
{
    [DbContext(typeof(HiScoreContext))]
    [Migration("20170526104051_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
