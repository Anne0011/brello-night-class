using Brello.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Brello.Tests.Models
{
    [TestClass]
    public class VoteTests
    {
        [TestMethod]
        public void EnsureICanCreateVoteClassInstance()
        {
            Vote vote = new Vote();
            Assert.IsNotNull(vote);
        }
    }
}