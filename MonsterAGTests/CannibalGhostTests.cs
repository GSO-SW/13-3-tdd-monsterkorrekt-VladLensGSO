using System;
using MonsterAG;

namespace MonsterAGTests
{
    [TestClass]
    public class CannibalGhostTests
    {

        [TestMethod]
        public void CannibalGhost_wirdKorrektErzeugt()
        {
            // Arrange
            string name = "hungrySpooky";

            // Act
            CannibalGhost cannibalGhost = new CannibalGhost(name);

            // Assert
            Assert.AreEqual(name, cannibalGhost.Name);
            Assert.AreEqual(1, cannibalGhost.Size);
        }

        [TestMethod]
        public void Eat_mitGeistSteigertSize()
        {
            // Arrange
            CannibalGhost cannibalGhost = new CannibalGhost("hungrySpooky");
            Ghost ghostToEat = new Ghost("Spooky");
            ghostToEat.Size = 5;
            SlimeGhost slimeGhostToEat = new SlimeGhost("Slimey");
            slimeGhostToEat.Size = 2;
            CannibalGhost cannibalGhostToEat = new CannibalGhost("tastyCannibal");
            cannibalGhostToEat.Size = 1;

            // Act
            cannibalGhost.Eat(ghostToEat);
            cannibalGhost.Eat(slimeGhostToEat);
            cannibalGhost.Eat(cannibalGhostToEat);

            // Assert
            Assert.AreEqual(9, cannibalGhost.Size);
            Assert.AreEqual(0, ghostToEat.Size);
            Assert.AreEqual(0, slimeGhostToEat.Size);
            Assert.AreEqual(0, cannibalGhostToEat.Size);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Eat_WithNullGhostThrowsException()
        {
            // Arrange
            CannibalGhost cannibalGhost = new CannibalGhost("hungrySpooky");
            Ghost ghostToEat = null;

            // Act
            cannibalGhost.Eat(ghostToEat);
        }
    }
}
