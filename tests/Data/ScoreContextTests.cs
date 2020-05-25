using Xunit;
using openrmf_msg_score.Models;
using openrmf_msg_score.Data;
using Microsoft.Extensions.Options;

namespace tests.Data
{
    public class ScoreContextTests
    {
        private readonly ScoreContext _scoreContext;

        public ScoreContextTests()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "mongodb://openrmfscore:openrmf1234!@localhost/openrmfscore?authSource=admin";
            settings.Database = "openrmfscore";

            _scoreContext = new ScoreContext(settings);
        }

        [Fact]
        public void Test_ScoreContextIsValid()
        {
            // Testing
            Assert.False(_scoreContext == null);
            Assert.False(_scoreContext.Scores == null);
        }
    }
}
