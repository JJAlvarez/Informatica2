using Examen;
using Xunit;

namespace ExamenTests
{
    public class Test
    {
        [Fact]
        public void ColocarBarco()
        {
            ITablero tablero = new Tablero(10);
            IBarco barco1 = new Barco(3, 1, 2, 1);
            IBarco barco2 = new Barco(4, 2, 1, 2);

            tablero.ColocarBarco(barco1);
            
            Assert.Equal(false, tablero.ColocarBarco(barco2));
        }

        [Fact]
        public void Atacar()
        {
            ITablero tablero = new Tablero(10);
            IBarco barco1 = new Barco(4, 3, 4, 2);

            tablero.ColocarBarco(barco1);

            Assert.Equal(true, tablero.Atacar(3, 7));
        }

        [Fact]
        public void EstaConcluido()
        {
            ITablero tablero = new Tablero(10);
            IBarco barco1 = new Barco(3, 0, 0, 1);
            IBarco barco2 = new Barco(3, 6, 0, 1);
            IBarco barco3 = new Barco(3, 10, 0, 1);

            tablero.ColocarBarco(barco1);
            tablero.ColocarBarco(barco2);
            tablero.ColocarBarco(barco3);

            for (int i = 0; i < barco1.Longitud; i++)
            {
                tablero.Atacar(i, 0);
                tablero.Atacar(i + 6, 0);
                tablero.Atacar(i + 10, 0);
            }

            Assert.Equal(true, tablero.EstaConcluido());
        }
    }
}
