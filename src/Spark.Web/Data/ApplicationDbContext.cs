/*
 * Copyright (c) 2019-2025, Incendi <info@incendi.no>
 *
 * SPDX-License-Identifier: BSD-3-Clause
 */

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Spark.Web.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Add stuff here:
        // NOTE: Id and ConcurrencyStamp must be static, hardcoded values (matching the
        // migration snapshot) - the IdentityRole constructor otherwise generates new Guids
        // on every build, which trips EF Core's PendingModelChangesWarning during Migrate().
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "453e564a-29b5-4f1f-b49b-1bd116778fce",
            ConcurrencyStamp = "38c23849-bc6b-451e-bba0-c817703d3168",
            Name = "Admin",
            NormalizedName = "ADMIN"
        });
    }
}