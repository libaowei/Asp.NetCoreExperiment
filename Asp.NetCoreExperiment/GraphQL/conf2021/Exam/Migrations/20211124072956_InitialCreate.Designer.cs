﻿// <auto-generated />
using System;
using Exam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exam.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20211124072956_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Exam.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Answer1")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Answer");

                    b.Property<bool>("IsTrue")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionID");

                    b.Property<string>("Sequre")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Exam.Models.ExamPaper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Memo")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("QuestionCount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("TotalScore")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ExamPapers");
                });

            modelBuilder.Entity("Exam.Models.ExamPaperQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExamPaperId")
                        .HasColumnType("int")
                        .HasColumnName("ExamPaperID");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionID");

                    b.HasKey("Id");

                    b.HasIndex("ExamPaperId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ExamPaperQuestions");
                });

            modelBuilder.Entity("Exam.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Question1")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Question");

                    b.Property<int>("QuestionTypeId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionTypeID");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<int>("SujectTypeId")
                        .HasColumnType("int")
                        .HasColumnName("SujectTypeID");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTypeId");

                    b.HasIndex("SujectTypeId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Exam.Models.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");
                });

            modelBuilder.Entity("Exam.Models.SubjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("SubjectTypes");
                });

            modelBuilder.Entity("Exam.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Tel")
                        .HasMaxLength(11)
                        .HasColumnType("varbinary(11)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Exam.Models.UserExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("ExamPapgerId")
                        .HasColumnType("int")
                        .HasColumnName("ExamPapgerID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("ExamPapgerId");

                    b.HasIndex("UserId");

                    b.ToTable("UserExams");
                });

            modelBuilder.Entity("Exam.Models.UserExamAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnswerId")
                        .HasColumnType("int")
                        .HasColumnName("AnswerID");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("UserExamId")
                        .HasColumnType("int")
                        .HasColumnName("UserExamID");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("UserExamId");

                    b.ToTable("UserExamAnswers");
                });

            modelBuilder.Entity("Exam.Models.Answer", b =>
                {
                    b.HasOne("Exam.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .IsRequired()
                        .HasConstraintName("FK_Answers_Questions");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Exam.Models.ExamPaperQuestion", b =>
                {
                    b.HasOne("Exam.Models.ExamPaper", "ExamPaper")
                        .WithMany("ExamPaperQuestions")
                        .HasForeignKey("ExamPaperId")
                        .IsRequired()
                        .HasConstraintName("FK_ExamPaperQuestions_ExamPapers");

                    b.HasOne("Exam.Models.Question", "Question")
                        .WithMany("ExamPaperQuestions")
                        .HasForeignKey("QuestionId")
                        .IsRequired()
                        .HasConstraintName("FK_ExamPaperQuestions_Questions");

                    b.Navigation("ExamPaper");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Exam.Models.Question", b =>
                {
                    b.HasOne("Exam.Models.QuestionType", "QuestionType")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Questions_QuestionTypes");

                    b.HasOne("Exam.Models.SubjectType", "SujectType")
                        .WithMany("Questions")
                        .HasForeignKey("SujectTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Questions_SubjectTypes");

                    b.Navigation("QuestionType");

                    b.Navigation("SujectType");
                });

            modelBuilder.Entity("Exam.Models.UserExam", b =>
                {
                    b.HasOne("Exam.Models.ExamPaper", "ExamPapger")
                        .WithMany("UserExams")
                        .HasForeignKey("ExamPapgerId")
                        .IsRequired()
                        .HasConstraintName("FK_UserExams_ExamPapers");

                    b.HasOne("Exam.Models.User", "User")
                        .WithMany("UserExams")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_UserExams_Users");

                    b.Navigation("ExamPapger");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Exam.Models.UserExamAnswer", b =>
                {
                    b.HasOne("Exam.Models.Answer", "Answer")
                        .WithMany("UserExamAnswers")
                        .HasForeignKey("AnswerId")
                        .IsRequired()
                        .HasConstraintName("FK_UserExamAnswers_Answers");

                    b.HasOne("Exam.Models.UserExam", "UserExam")
                        .WithMany("UserExamAnswers")
                        .HasForeignKey("UserExamId")
                        .IsRequired()
                        .HasConstraintName("FK_UserExamAnswers_UserExams");

                    b.Navigation("Answer");

                    b.Navigation("UserExam");
                });

            modelBuilder.Entity("Exam.Models.Answer", b =>
                {
                    b.Navigation("UserExamAnswers");
                });

            modelBuilder.Entity("Exam.Models.ExamPaper", b =>
                {
                    b.Navigation("ExamPaperQuestions");

                    b.Navigation("UserExams");
                });

            modelBuilder.Entity("Exam.Models.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("ExamPaperQuestions");
                });

            modelBuilder.Entity("Exam.Models.QuestionType", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Exam.Models.SubjectType", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Exam.Models.User", b =>
                {
                    b.Navigation("UserExams");
                });

            modelBuilder.Entity("Exam.Models.UserExam", b =>
                {
                    b.Navigation("UserExamAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
