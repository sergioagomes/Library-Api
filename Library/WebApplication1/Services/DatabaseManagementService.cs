using System;
using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Service;
    public static class DatabaseManagementService
{
    public static void MigrationInitialisation(this IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            var serviceDb = serviceScope.ServiceProvider
                             .GetService<MysqlContext>();

            serviceDb.Database.Migrate();
        }
    }
}