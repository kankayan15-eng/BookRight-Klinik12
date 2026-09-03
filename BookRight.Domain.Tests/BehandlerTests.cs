using BookRight.Domain.Aggregates;
using BookRight.Domain.Enums;

namespace BookRight.Domain.Tests
{
    public class BehandlerTests
    {
        [Fact]
        public void KanUdføre_Introduktionssamtale_UdenAutorisation()
        {
            // Arrange
            var behandler = new Behandler(
                "Lars",
                "Læge",
                "lars@test.dk",
                "11111111",
                "AUT-1",
                AutorisationsType.Fysioterapeut);

            var introduktionssamtale = new Behandlingstype(
                "Introduktionssamtale",
                15,
                0m,
                AutorisationsType.Ingen,
                BehandlingsType.Introduktionssamtale);

            // Act
            var resultat = behandler.KanUdføre(introduktionssamtale);

            // Assert
            Assert.True(resultat);
        }
    }
}