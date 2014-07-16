using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {

        /// <summary>
        /// In between
        /// </summary>
        [TestMethod]
        public void Normal()
        {
            try
            {
                Game game = new Game();

                int[] arr = { 10, 3, 5 };
           
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
        /// <summary>
        /// gutter condition all zero
        /// </summary>
        [TestMethod]
        public void AllZero()
        {
            try
            {
                Game game = new Game();

             
                int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
             
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
        /// <summary>
        /// spare condition
        /// </summary>

        [TestMethod]
        public void Spare()
        {
            try
            {
                Game game = new Game();
                int[] arr = { 5, 5, 5, 5, 5, 5,5, 5,5, 5, 5,5, 5, 5, 5,5, 5, 5, 5, 5 ,5};
                foreach (int i in arr)
                {
                    game.Roll(i);
                }

                int res = game.GetScore();

                Assert.AreEqual(res, 150);


            }

            catch (Exception ex)
            {
                Assert.Fail("Caught exception"
                    , ex.GetType().Name);
            }
        }
        /// <summary>
        /// strike condition
        /// </summary>
        [TestMethod]
        public void Strike()
        {
            try
            {
                Game game = new Game();

              
                  int[] arr = { 10, 10, 10, 10,10, 10, 10, 10, 10, 10,10,10};
             
                foreach (int i in arr)
                {
                    game.Roll(i);
                }

                int res = game.GetScore();

                Assert.AreEqual(res, 300);


            }

            catch (Exception ex)
            {
                Assert.Fail("Caught exception"
                    , ex.GetType().Name);
            }
        }



        [TestMethod]
        public void StrikeSpare()
        {
            try
            {
                Game game = new Game();


                int[] arr = { 10, 10, 10, 5, 5, 10, 10, 10, 10, 10, 10, 10, 10 };

                foreach (int i in arr)
                {
                    game.Roll(i);
                }

                int res = game.GetScore();

                Assert.AreEqual(res, 275);


            }

            catch (Exception ex)
            {
                Assert.Fail("Caught exception"
                    , ex.GetType().Name);
            }
        }
    }
}
