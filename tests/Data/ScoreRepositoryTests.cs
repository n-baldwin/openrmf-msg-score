using Xunit;
using openrmf_msg_score.Models;
using openrmf_msg_score.Data;
using System.Threading.Tasks;
using System;
using MongoDB.Bson;

namespace tests.Data
{
    public class ScoreRepositoryTests
    {
        private readonly ScoreRepository _scoreRepository;

        public ScoreRepositoryTests()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "mongodb://openrmfscore:openrmf1234!@localhost/openrmfscore?authSource=admin";
            settings.Database = "openrmfscore";

            _scoreRepository = new ScoreRepository(settings);
        }

        [Fact]
        public async Task Test_ScoreRepositoryIsValid()
        {
            Score score = new Score();
            ObjectId objId = ObjectId.GenerateNewId();

            score.InternalId = objId;

            // Testing
            // Ignoring below due to building problems on Github.
            /*
            await _scoreRepository.GetAllScores();
            await _scoreRepository.GetScore("id");
            await _scoreRepository.GetScorebyArtifact("id");
            await _scoreRepository.GetScore("body", DateTime.Now, 1024);
            await _scoreRepository.GetSystemScores("id");
            await _scoreRepository.AddScore(score);
            await _scoreRepository.UpdateScore(score);
            await _scoreRepository.RemoveScore(objId);
            */
        }
    }
}
