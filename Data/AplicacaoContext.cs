﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Aplicacao.Models;

namespace Aplicacao.Data
{
    public partial class AplicacaoContext : DbContext
    {
        public AplicacaoContext()
        {
        }

        public AplicacaoContext(DbContextOptions<AplicacaoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Veiculos> Veiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CHGKPUA\\SQLEXPRESS;Initial Catalog=EMPRESA;Persist Security Info=True;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}