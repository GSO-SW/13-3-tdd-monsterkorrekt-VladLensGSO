using System;
using MonsterAG;

namespace MonsterAGTests
{
    [TestClass]
    public class GhostTests
    {

        [TestMethod]
        public void Ghost_wirdKorrektErstellt()
        {
            // Arrange
            string name = "Spooky";

            // Act
            Ghost ghost = new Ghost(name);

            // Assert
            Assert.AreEqual(name, ghost.Name);
            Assert.AreEqual(1, ghost.Size);
        }

        [TestMethod]
        public void Size_KannGesetztWerden()
        {
            // Arrange
            Ghost ghost = new Ghost("Spooky");
            int size = 10;

            // Act
            ghost.Size = size;

            // Assert
            Assert.AreEqual(size, ghost.Size);
        }

        [TestMethod]
        public void Haunt_ErzeugtAusgabe()
        {
            // Arrange
            Ghost ghost = new Ghost("Spooky");

            // Act
            string ausgabe = ghost.Haunt();

            // Assert
            Assert.AreEqual("Spooky sagt: 'Buh'", ausgabe);
        }
    }
}

