using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solver;

namespace Solver_3._0
{
    [TestClass]
    public class QuadraticEquatonSolverTest
    {
        //делаем общий метод, который выполняет тестирование уравнение на каких-то данных
        void TestEquation (double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(expectedResult.Length, result.Length);
            
            for(int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }

        [TestMethod]
        public void TestSolve()
        {
            ////1.Arrange
            //var a = 1;
            //var b = -3;
            //var c = 2;

            ////2.Act
            //var result = QuadraticEquationsSolver.Solve(a,b,c);

            ////3.Assert:
            //Assert.AreEqual(2, result.Length);
            //Assert.AreEqual(2, result[0]);
            //Assert.AreEqual(1, result[1]);
            TestEquation(1, -3, 2, 2, 1 );
        }
        [TestMethod]
        public void NegativeDiscriminant()
        {
            TestEquation(1, 1, 1);
           
        }
    }
}
