using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AppVeyorSample.Controllers;
using AppVeyorSample.Tests.Fixtures;

using FluentAssertions;

using Xunit;

namespace AppVeyorSample.Tests
{
    public class ValuesControllerTest : IClassFixture<ValuesControllerFixture>
    {
        private readonly ValuesController _controller;

        public ValuesControllerTest(ValuesControllerFixture fixture)
        {
            this._controller = fixture.ValuesController;
        }

        [Fact]
        public void Given_Parameter_Get_ShouldReturn_Result()
        {
            var result = this._controller.Get(id: 1);
            result.Should().Be("value");
        }
    }
}
