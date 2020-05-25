using Xunit;
using openrmf_msg_score.Models;
using System;

namespace tests.Models
{
    public class ScoreTests
    {
        [Fact]
        public void Test_NewScoreIsValid()
        {
            Score score = new Score();

            // Testing
            Assert.False(score == null);
        }
    
        [Fact]
        public void Test_ScoreWithDataIsValid()
        {
            Score score = new Score();

            score.hostName = "my host name";
            score.stigRelease = "V1";
            score.stigType = "Google Chrome";
            score.created = DateTime.Now;
            score.updatedOn = DateTime.Now;
            score.createdBy = Guid.NewGuid();
            score.updatedBy = Guid.NewGuid();

            // Testing
            Assert.True(score.hostName == "my host name");
            Assert.True(score.stigType == "Google Chrome");
            Assert.True(score.stigRelease == "V1");
            Assert.True(score.title == "my host name-Google Chrome-V1");  // readonly from other fields
            Assert.True(score.updatedOn.HasValue);
            Assert.False(score.createdBy == null);
            Assert.False(score.updatedBy == null);
            Assert.False(score.created == null);
            Assert.False(score.updatedOn == null);
        }

        [Fact]
        public void Test_ScoreWithCalculatedTotalsIsValid()
        {
            Score score = new Score();

            score.totalCat1Open = 1;
            score.totalCat1NotApplicable = 1;
            score.totalCat1NotAFinding = 1;
            score.totalCat1NotReviewed = 1;
            score.totalCat2Open = 3;
            score.totalCat2NotApplicable = 5;
            score.totalCat2NotAFinding = 10;
            score.totalCat2NotReviewed = 20;
            score.totalCat3Open = 8;
            score.totalCat3NotApplicable = 7;
            score.totalCat3NotAFinding = 10;
            score.totalCat3NotReviewed = 10;

            // Testing
            Assert.True(score != null);
            Assert.True(score.totalCat1Open == 1);
            Assert.True(score.totalCat1NotApplicable == 1);
            Assert.True(score.totalCat1NotAFinding == 1);
            Assert.True(score.totalCat1NotReviewed == 1);
            Assert.True(score.totalCat2Open == 3);
            Assert.True(score.totalCat2NotApplicable == 5);
            Assert.True(score.totalCat2NotAFinding == 10);
            Assert.True(score.totalCat2NotReviewed == 20);
            Assert.True(score.totalCat3Open == 8);
            Assert.True(score.totalCat3NotApplicable == 7);
            Assert.True(score.totalCat3NotAFinding == 10);
            Assert.True(score.totalCat3NotReviewed == 10);
            Assert.True(score.totalOpen == 12);
            Assert.True(score.totalNotApplicable == 13);
            Assert.True(score.totalNotAFinding == 21);
            Assert.True(score.totalNotReviewed == 31);
            Assert.True(score.totalCat1 == 4);
            Assert.True(score.totalCat2 == 38);
            Assert.True(score.totalCat3 == 35);
        }
    }
}
