using Xunit;
using openrmf_msg_score.Models;
using System;

namespace tests.Models
{
    public class ArtifactTests
    {
        [Fact]
        public void Test_NewArtifactIsValid()
        {
            Artifact artifact = new Artifact();

            // Testing
            Assert.False(artifact == null);
        }
    
        [Fact]
        public void Test_ArtifactWithDataIsValid()
        {
            Artifact artifact = new Artifact();

            artifact.created = DateTime.Now;
            artifact.updatedOn = DateTime.Now;
            artifact.createdBy = Guid.NewGuid();
            artifact.updatedBy = Guid.NewGuid();
            artifact.systemGroupId = "Group ID";
            artifact.systemTitle = "Title";
            artifact.hostName = "myHost";
            artifact.stigType = "Google Chrome";
            artifact.stigRelease = "Version 1";
            artifact.version = "Version 1";
            artifact.InternalId = "id";
            artifact.CHECKLIST = new CHECKLIST();

            // Testing
            Assert.True(artifact.systemGroupId == "Group ID");
            Assert.True(artifact.systemTitle == "Title");
            Assert.True(artifact.hostName == "myHost");
            Assert.True(artifact.stigType == "Google Chrome");
            Assert.True(artifact.stigRelease == "Version 1");
            Assert.True(artifact.title == "myHost-Google Chrome-Version 1");
            Assert.True(artifact.version == "Version 1");
            Assert.True(artifact.InternalId == "id");
            Assert.False(artifact.created == null);
            Assert.False(artifact.updatedOn == null);
            Assert.False(artifact.createdBy == null);
            Assert.False(artifact.updatedBy == null);
            Assert.False(artifact.CHECKLIST == null);
        }
    }
}
