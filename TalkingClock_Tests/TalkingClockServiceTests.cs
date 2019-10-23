using Microsoft.VisualStudio.TestTools.UnitTesting;
using TalkingClock.Services;

namespace TalkingClock_Tests
{
    [TestClass]
    public class TalkingClockServiceTests
    {
        // todo: validation input parameter tests

        [TestMethod]
        public void TalkingClockService_ShouldReturnOneOClock()
        {
            // act
            const string input = "1:00";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "One o\'clock");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnTwoOClock()
        {
            // act
            const string input = "2:00";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Two o\'clock");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnTwelveOClock()
        {
            // act
            const string input = "12:00";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Twelve o\'clock");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnOneOClockFromTwentyFourHourClock()
        {
            // act
            const string input = "13:00";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "One o\'clock");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnElevenOClockFromTwentyFourHourClock()
        {
            // act
            const string input = "23:00";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Eleven o\'clock");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnTwelveOClockFromTwentyFourHourClock()
        {
            // act
            const string input = "00:00";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Twelve o\'clock");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnFivePastOne()
        {
            // act
            const string input = "13:05";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Five past one");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnTenPastOne()
        {
            // act
            const string input = "13:10";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Ten past one");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnTwentyFivePastOne()
        {
            // act
            const string input = "13:25";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Twenty five past one");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnHalfPastOne()
        {
            // act
            const string input = "13:30";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Half past one");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnTwentyFiveToTwo()
        {
            // act
            const string input = "13:35";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Twenty five to two");
        }

        [TestMethod]
        public void TalkingClockService_ShouldReturnFiveToTwo()
        {
            // act
            const string input = "13:55";
            var service = new TalkingClockService();

            // arrange
            var result = service.GetHumanFriendlyText(input);

            // assert
            Assert.AreEqual(result, "Five to two");
        }
    }
}

