using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using openstig_msg_score.Data;

namespace openstig_msg_score.Models
{
    public class Score
    {

        public Score () {
            id = Guid.NewGuid();
        }

        #region members
        [BsonId]
        // standard BSonId generated by MongoDb
        public ObjectId InternalId { get; set; }
        public Guid id { get; set; }
        public Guid artifactId { get; set;}
        public string title { get; set; }
        public string description { get; set; }

        [BsonDateTimeOptions]
        public DateTime created { get; set; }
        [BsonDateTimeOptions]
        // attribute to gain control on datetime serialization
        public DateTime? updatedOn { get; set; }
        public Guid createdBy { get; set; }
        public Guid? updatedBy { get; set; }


        public int totalCat1Open { get; set; }
        public int totalCat1NotApplicable { get; set; }
        public int totalCat1NotAFinding { get; set; }
        public int totalCat1NotReviewed { get; set; }
        public int totalCat2Open { get; set; }
        public int totalCat2NotApplicable{ get; set; }
        public int totalCat2NotAFinding { get; set; }
        public int totalCat2NotReviewed { get; set; }
        public int totalCat3Open { get; set; }
        public int totalCat3NotApplicable { get; set; }
        public int totalCat3NotAFinding { get; set; }
        public int totalCat3NotReviewed { get; set; }

        public int totalOpen { get { return totalCat1Open + totalCat2Open + totalCat3Open;} }
        public int totalNotApplicable { get { return totalCat1NotApplicable + totalCat2NotApplicable + totalCat3NotApplicable;} }
        public int totalNotAFinding { get { return totalCat1NotAFinding + totalCat2NotAFinding + totalCat3NotAFinding;} }
        public int totalNotReviewed { get { return totalCat1NotReviewed + totalCat2NotReviewed + totalCat3NotReviewed;} }
        #endregion

        public async void SaveScore () {
            try {
                Settings s = new Settings();
                s.ConnectionString = Environment.GetEnvironmentVariable("mongoConnection");
                s.Database = Environment.GetEnvironmentVariable("mongodb");

                ScoreRepository _scoreRepo = new ScoreRepository(s);
                await _scoreRepo.AddScore(this);
            }
            catch (Exception ex) {
                Console.WriteLine(string.Format("Error Saving Score for {0}. {1}", this.title, ex.Message));
                throw ex;
            }
        }
    }
}