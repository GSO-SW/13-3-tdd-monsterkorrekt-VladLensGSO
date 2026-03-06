// Unserer Namenskonvention folgend sollten diese Tests eigentlich in die entsprechenden
// Klassen eingefügt werden. Ich habe Sie hier als eigene Testklasse implementiert, da es
// so einfacher ist, Ihren Fortschritt zu überprüfen.
// 
// Sie dürfen die Datei gerne auseinanderpflücken ;)
//
// Testfälle wurden mit Hilfe einer KI erzeugt.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterAG;

namespace MonsterAGTests
{
    [TestClass]
    public class MonsterAGExpertTests
    {
        /// <summary>
        /// Challenge 1: Validierung im Setter.
        /// Die Größe eines Geistes darf niemals negativ werden. 
        /// Wird versucht, einen negativen Wert zu setzen, soll die Size stattdessen auf 0 gesetzt werden.
        /// </summary>
        [TestMethod]
        public void Size_NegativeValueSetsZero()
        {
            // Arrange
            Ghost ghost = new Ghost("Spooky");

            // Act
            ghost.Size = -1;

            // Assert
            Assert.AreEqual(0, ghost.Size);
        }

        /// <summary>
        /// Challenge 2: Identitätsschutz.
        /// Ein CannibalGhost ist zwar hungrig, sollte sich aber nicht selbst fressen können!
        /// Wenn Eat() mit der eigenen Instanz aufgerufen wird, darf sich die Size nicht ändern.
        /// </summary>
        [TestMethod]
        public void Eat_CannotEatSelf()
        {
            // Arrange
            CannibalGhost cg = new CannibalGhost("Hannibal");
            int initialSize = cg.Size;
            
            // Act
            cg.Eat(cg);

            // Assert
            Assert.AreEqual(initialSize, cg.Size, "Ein CannibalGhost sollte sich nicht selbst fressen können.");
        }

        /// <summary>
        /// Challenge 3: Spezialisierung des Verhaltens.
        /// Wenn ein CannibalGhost einen SlimeGhost frisst, bekommt er nicht nur dessen Size,
        /// sondern er "schleimt" danach vor Freude einmalig.
        /// Die Haunt() Methode soll für CannibalGhosts erweitert werden: 
        /// Falls sie ZUVOR einen SlimeGhost gefressen haben, wird der Nachricht 
        /// ein "*Rülps* ...lecker Schleim!" vorangestellt.
        /// </summary>
        [TestMethod]
        public void Haunt_AfterEatingSlimeShowsSpecialMessage()
        {
            // Arrange
            CannibalGhost eater = new CannibalGhost("Hannibal");
            SlimeGhost snack = new SlimeGhost("Slimer");

            // Act
            eater.Eat(snack);
            string message = eater.Haunt();

            // Assert
            StringAssert.Contains(message, "*Rülps* ...lecker Schleim!", "Nach einem SlimeGhost sollte ein Rülpser erscheinen.");
            StringAssert.Contains(message, "Hannibal sagt: 'Buh'");
        }

        /// <summary>
        /// Challenge 4: Namensschutz.
        /// Namen dürfen nicht leer sein oder nur aus Leerzeichen bestehen.
        /// Wirf eine ArgumentException im Konstruktor, falls ein ungültiger Name übergeben wird.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Ghost_Constructor_ThrowsOnEmptyName()
        {
            // Act
            Ghost ghost = new Ghost("   ");
        }
    }
}