using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CommonLayer
{
    [Trait("Category", "Common Layer")]
    public class CommonLayerTests
    {
        ITestOutputHelper _testOutputHelper;
        public CommonLayerTests(ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ReturnsTrue()
        {
            Assert.True(true);
        }
    }
}
