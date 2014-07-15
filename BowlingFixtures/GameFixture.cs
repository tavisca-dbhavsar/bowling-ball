using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Game game = new Game();

                int[] arr = { 10, 3, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                //int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
               // int[] arr = { 10, 10, 10, 10,10, 10, 10, 10, 10, 10,0,0};
             //   int[] arr = { 3,7,3,7,3,7,3,7,3,7,3,7,3,7,3,7,3,7,3,7 }; 
                foreach (int i in arr)
                {
                    game.Roll(i);
                }

                int res = game.GetScore();

                Assert.AreEqual(res,26);


            }

            catch (Exception ex)
            {
                Assert.Fail("Caught exception"
                    , ex.GetType().Name);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                Game game = new Game();

                //int[] arr = { 10, 3, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                // int[] arr = { 10, 10, 10, 10,10, 10, 10, 10, 10, 10,0,0};
               // int[] arr = { 3, 7, 3, 7, 3, 7, 3, 7, 3, 7, 3, 7, 3, 7, 3, 7, 3, 7, 3, 7 };
                foreach (int i in arr)
                {
                    game.Roll(i);
                }

                int res = game.GetScore();

                Assert.AreEqual(res, 0);


            }

            catch (Exception ex)
            {
                Assert.Fail("Caught exception"
                    , ex.GetType().Name);
            }
        }
     
    }
}
