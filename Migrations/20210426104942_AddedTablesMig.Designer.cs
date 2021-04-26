﻿// <auto-generated />
using ClassificationAppBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassificationAppBackend.Migrations
{
    [DbContext(typeof(ClassifcatiionAppDbContext))]
    [Migration("20210426104942_AddedTablesMig")]
    partial class AddedTablesMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassificationAppBackend.Models.Diseases.HeartFailure.HeartFailureDataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ChestPainType")
                        .HasColumnType("int");

                    b.Property<int>("Cholesterol")
                        .HasColumnType("int");

                    b.Property<bool>("ExerciseAngina")
                        .HasColumnType("bit");

                    b.Property<bool>("FastingBloodSugar")
                        .HasColumnType("bit");

                    b.Property<int>("MaxHeartRate")
                        .HasColumnType("int");

                    b.Property<float>("OldPeak")
                        .HasColumnType("real");

                    b.Property<int>("RestingBpS")
                        .HasColumnType("int");

                    b.Property<bool>("RestingEcg")
                        .HasColumnType("bit");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("StSlope")
                        .HasColumnType("int");

                    b.Property<bool>("Target")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("HeartFailureData");
                });

            modelBuilder.Entity("ClassificationAppBackend.Models.Diseases.HeartFailure.HeartFailurePredictionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Age")
                        .HasColumnType("real");

                    b.Property<float>("Chest_pain_type")
                        .HasColumnType("real");

                    b.Property<float>("Cholesterol")
                        .HasColumnType("real");

                    b.Property<string>("Exercise_angina")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Fasting_blood_sugar")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("HeartFailurePredictionResult")
                        .HasColumnType("int");

                    b.Property<float>("Max_heart_rate")
                        .HasColumnType("real");

                    b.Property<float>("Oldpeak")
                        .HasColumnType("real");

                    b.Property<float>("Resting_bp_s")
                        .HasColumnType("real");

                    b.Property<string>("Resting_ecg")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<float>("ST_slope")
                        .HasColumnType("real");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("PredictHeartFailure");
                });

            modelBuilder.Entity("ClassificationAppBackend.Models.Diseases.Stroke.StrokeDataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("AverageGlucoseLevel")
                        .HasColumnType("float");

                    b.Property<double>("BMI")
                        .HasColumnType("float");

                    b.Property<bool>("EverMarried")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("HasHeartDisease")
                        .HasColumnType("bit");

                    b.Property<bool>("HasHypertension")
                        .HasColumnType("bit");

                    b.Property<string>("ResidenceType")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SmokingStatus")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Target")
                        .HasColumnType("bit");

                    b.Property<string>("WorkType")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("StrokeData");
                });

            modelBuilder.Entity("ClassificationAppBackend.Models.Diseases.Stroke.StrokePredictionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("AverageGlucoseLevel")
                        .HasMaxLength(250)
                        .HasColumnType("float");

                    b.Property<double>("BMI")
                        .HasColumnType("float");

                    b.Property<string>("EverMarried")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("HasHeartDisease")
                        .HasColumnType("int");

                    b.Property<int>("HasHypertension")
                        .HasColumnType("int");

                    b.Property<string>("ResidenceType")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SmokingStatus")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("StrokePredictionResult")
                        .HasColumnType("int");

                    b.Property<string>("WorkType")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("PredictionsStroke");
                });

            modelBuilder.Entity("ClassificationAppBackend.Models.PatientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}