using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new User
            {
                Name = "Test User 1",
                Email = "test.user.1@devmail.com",
                Address = new Address
                {
                    Street = "123 Market St",
                    City = "Boston",
                    ZipCode = "42342",
                }
            },
            new User
            {
                Name = "Test User 2",
                Email = "test.user.2@devmail.com",
                Address = new Address
                {
                    Street = "16456 Market St",
                    City = "Chicago",
                    ZipCode = "5345",
                }
            },
            new User
            {
                Name = "Test User 3",
                Email = "test.user.3@devmail.com",
                Address = new Address
                {
                    Street = "53543 Market St",
                    City = "Miami",
                    ZipCode = "53534",
                }
            }
        };
    }
}
