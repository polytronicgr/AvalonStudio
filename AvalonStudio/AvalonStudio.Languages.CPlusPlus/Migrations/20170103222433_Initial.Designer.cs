﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AvalonStudio.Languages.CPlusPlus.ProjectDatabase;

namespace AvalonStudio.Languages.CPlusPlus.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20170103222433_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("AvalonStudio.Languages.CPlusPlus.ProjectDatabase.SourceFiles", b =>
                {
                    b.Property<int>("SourceFilesId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("RelativePath");

                    b.HasKey("SourceFilesId");

                    b.ToTable("SourceFiles");
                });
        }
    }
}