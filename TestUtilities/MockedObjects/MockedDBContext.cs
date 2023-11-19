﻿using DataAccessLayer.Data;
using EntityFrameworkCore.Testing.NSubstitute.Helpers;
using Microsoft.EntityFrameworkCore;
using TestUtilities.Data;

namespace TestUtilities.MockedObjects
{
    public static class MockedDBContext
    {
        public static string RandomDBName => Guid.NewGuid().ToString();

        public static DbContextOptions<BookHubDBContext> GenerateNewInMemoryDBContextOptons()
        {
            var dbContextOptions = new DbContextOptionsBuilder<BookHubDBContext>()
                .UseInMemoryDatabase(RandomDBName)
                .Options;

            return dbContextOptions;
        }

        public static BookHubDBContext CreateFromOptions(DbContextOptions<BookHubDBContext> options)
        {
            var dbContextToMock = new BookHubDBContext(options);

            var dbContext = new MockedDbContextBuilder<BookHubDBContext>()
                .UseDbContext(dbContextToMock)
                .UseConstructorWithParameters(options)
                .MockedDbContext;

            PrepareData(dbContext);

            return dbContext;
        }

        public static void PrepareData(BookHubDBContext dbContext)
        {
            dbContext.Books.AddRange(TestDataHelper.GetFakeBooks());

            dbContext.SaveChanges();
        }

        public static async Task PrepareDataAsync(BookHubDBContext dbContext)
        {
            dbContext.Books.AddRange(TestDataHelper.GetFakeBooks());

            await dbContext.SaveChangesAsync();
        }
    }
}