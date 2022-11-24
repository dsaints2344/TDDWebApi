using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using CloudCustomers.UnitTests.Fixtures;
using CloudCustomers.UnitTests.Helpers;
using Moq;
using Moq.Protected;

namespace CloudCustomers.UnitTests.Systems.Services
{
    public class TestUsersService
    {
        [Fact]
        public async Task GetAllUsers_WhenCalled_InvokeHttpRequest()
        {
            //Arrange 
            var expectedResponse = UsersFixture.GetTestUsers();
            var handlerMock = MockHttpMessageHandler<User>.SetupBasicResourceList(expectedResponse);
            var httpClient = new HttpClient(handlerMock.Object);
            var service = new UsersService(httpClient);
            //Act

            await service.GetAllUsers();

            //Assert
            // Verify HTTP request is made
            handlerMock.Protected().Verify("SendAsync", Times.Exactly(1), 
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get),
                ItExpr.IsAny<CancellationToken>()
                );

        }
    }
}
