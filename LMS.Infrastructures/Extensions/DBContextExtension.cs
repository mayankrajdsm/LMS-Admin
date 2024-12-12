using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Extensions
{
    public static class DBContextExtension
    {
        public static async Task<List<T>> ExecuteQueryAsync<T>(this DbContext context, string sqlQuery, object? param = null) where T : class
        {
            return await context.Set<T>().FromSqlRaw(sqlQuery, param).ToListAsync();
        }
        public static async Task<T> ExecuteQueryAsyncSingleOrDefault<T>(this DbContext context, string sqlQuery, object? param = null) where T : class
        {
            return await context.Set<T>().FromSqlRaw(sqlQuery, param).FirstOrDefaultAsync();
        }
        public static async Task<int> ExecuteQueryAsync(this DbContext context, string sqlQuery, object? param = null)
        {

            return await context.Database.ExecuteSqlRawAsync(sqlQuery, param);
        }
        public static async Task<int> ExecuteStoredProcedureAsync(this DbContext context, string sqlQuery, object[] param)
        {

            return await context.Database.ExecuteSqlRawAsync(sqlQuery, param);
        }
    }
}
