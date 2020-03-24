using NUnit.Framework;
using Driver;

namespace Tests
{
    public class Setup
    {
        [SetUp]
        public void SetUp() => DriverOfChrome.ConfigureDriver();

        [TearDown]
        public void TearDown() => DriverOfChrome.CloseDriver();
    }
}
