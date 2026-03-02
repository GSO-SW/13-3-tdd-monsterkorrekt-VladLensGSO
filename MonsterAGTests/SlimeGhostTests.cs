using System;
using MonsterAG;

namespace MonsterAGTests
{
    [TestClass]
    public class SlimeGhostTests
    {

        [TestMethod]
        public void SlimeGhost_wirdKorrektErstellt()
        {
            // Arrange
            string name = "SlimeSpooky";

            // Act
            SlimeGhost slimeGhost = new SlimeGhost(name);

            // Assert
            Assert.AreEqual(name, slimeGhost.Name);
            Assert.AreEqual(1, slimeGhost.Size);
        }

        [TestMethod]
        public void Slime_erzeugtSlimeMessageMitNamen()
        {
            // Arrange
            string name = "SlimeSpooky";
            SlimeGhost slimeGhost = new SlimeGhost(name);

            // Act
            string slimeMessage = slimeGhost.Slime();

            // Assert
            Assert.AreEqual("SlimeSpooky hinterlässt eine Schleimspur.", slimeMessage);
        }


        [TestMethod]
        public void Haunt_erzeugtSlimeUndBuhMessage()
        {
            // Arrange
            SlimeGhost slimeGhost = new SlimeGhost("SlimeSpooky");

            // Act
            string ausgabe = slimeGhost.Haunt();

            // Assert
            Assert.AreEqual("SlimeSpooky hinterlässt eine Schleimspur.\r\nSlimeSpooky sagt: 'Buh'", ausgabe);
        }
    }
}

