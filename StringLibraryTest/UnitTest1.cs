using Microsoft.VisualStudio.TestPlatform.Utilities;
using UtilityLibraries;


namespace StringLibraryTest;

[TestClass]
public class StringLibraryTests
{ 
    [TestCategory("StringExtensions")]
    [TestMethod]
    public void StartsWithUpperShouldReturnTrueIfUpperCase()
    {
        Assert.IsTrue("Hello".StartsWithUpper(),"This should be true");
    }

    [TestMethod]   
    public void TestMethod2()
    {
       Assert.IsFalse("hello".StartsWithUpper(),"This should be false");
    }
}