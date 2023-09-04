﻿
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;
using PROJETOMVC.Models;

namespace PROJETOMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Lunch> Lunchs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhe { get; set; }

    }
}