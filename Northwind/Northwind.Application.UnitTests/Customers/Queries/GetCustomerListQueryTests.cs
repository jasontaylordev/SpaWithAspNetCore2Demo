using System;
using Xunit;
using Northwind.Application.Customers.Queries.GetCustomerList;
using Northwind.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using Northwind.Domain;
using Northwind.Application.Tests.Infrastructure;

namespace Northwind.Application.Tests.Customers.Queries
{
    [Collection("QueryCollection")]
    public class GetCustomerListQueryTests
    {
        private readonly NorthwindContext _context;

        public GetCustomerListQueryTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
        }

        [Fact]
        public async Task ShouldReturnAllCustomers()
        {
            var query = new GetCustomerListQuery(_context);

            var result = await query.Execute();

            Assert.Equal(3, result.Count());
        }
    }
}
