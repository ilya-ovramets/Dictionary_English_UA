using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.DataBase;

public partial class DictionaryContext : DbContext
{
    public DictionaryContext()
    {
    }

    public DictionaryContext(DbContextOptions<DictionaryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dictionary> Dictionaries { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    public virtual DbSet<Wordsdictionary> Wordsdictionaries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=Dictionary", ServerVersion.Parse("10.3.22-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Dictionary>(entity =>
        {
            entity.HasKey(e => e.DictionaryId).HasName("PRIMARY");

            entity.ToTable("dictionaries");

            entity.Property(e => e.DictionaryId)
                .HasColumnType("int(11)")
                .HasColumnName("dictionary_id");
            entity.Property(e => e.MiddleWords)
                .HasColumnType("int(11)")
                .HasColumnName("middle_words");
            entity.Property(e => e.StrongWords)
                .HasColumnType("int(11)")
                .HasColumnName("strong_words");
            entity.Property(e => e.WeakWords)
                .HasColumnType("int(11)")
                .HasColumnName("weak_words");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.DictionaryId, "dictionary_id");

            entity.HasIndex(e => e.UserName, "user_name").IsUnique();

            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.DictionaryId)
                .HasColumnType("int(11)")
                .HasColumnName("dictionary_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(30)
                .HasColumnName("user_password");

            entity.HasOne(d => d.Dictionary).WithMany(p => p.Users)
                .HasForeignKey(d => d.DictionaryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("users_ibfk_1");
        });

        modelBuilder.Entity<Word>(entity =>
        {
            entity.HasKey(e => e.WordId).HasName("PRIMARY");

            entity.ToTable("words");

            entity.HasIndex(e => e.Word1, "word").IsUnique();

            entity.Property(e => e.WordId)
                .HasColumnType("int(11)")
                .HasColumnName("word_id");
            entity.Property(e => e.Translate)
                .HasMaxLength(50)
                .HasColumnName("translate");
            entity.Property(e => e.Word1)
                .HasMaxLength(50)
                .HasColumnName("word");
        });

        modelBuilder.Entity<Wordsdictionary>(entity =>
        {
            entity.HasKey(e => e.WordDictionaryId).HasName("PRIMARY");

            entity.ToTable("wordsdictionaries");

            entity.HasIndex(e => e.DictionaryId, "dictionary_id");

            entity.HasIndex(e => e.WordId, "word_id");

            entity.Property(e => e.WordDictionaryId)
                .HasColumnType("int(11)")
                .HasColumnName("wordDictionary_id");
            entity.Property(e => e.DictionaryId)
                .HasColumnType("int(11)")
                .HasColumnName("dictionary_id");
            entity.Property(e => e.Progres)
                .HasColumnType("int(100)")
                .HasColumnName("progres");
            entity.Property(e => e.WordId)
                .HasColumnType("int(11)")
                .HasColumnName("word_id");

            entity.HasOne(d => d.Dictionary).WithMany(p => p.Wordsdictionaries)
                .HasForeignKey(d => d.DictionaryId)
                .HasConstraintName("wordsdictionaries_ibfk_1");

            entity.HasOne(d => d.Word).WithMany(p => p.Wordsdictionaries)
                .HasForeignKey(d => d.WordId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("wordsdictionaries_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
