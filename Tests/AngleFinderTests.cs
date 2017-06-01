using Xunit;
using System.Collections.Generic;

namespace ClockAngle
{
  public class AngleFinderTests
  {
    [Fact]
    public void MinutePosition_ReturnsMinuteHandDegrees_15()
    {
      int minutes = 15;
      int expectedAngle = 90;
      AngleFinder myFinder = new AngleFinder(0, minutes);
      int result = myFinder.MinutePosition();
      Assert.Equal(expectedAngle, result);
    }

    [Fact]
    public void HourPosition_ReturnsHourHandDegrees_5()
    {
      int hour = 5;
      int expectedAngle = 150;
      AngleFinder myFinder = new AngleFinder(hour, 0);
      int result = myFinder.HourPosition();
      Assert.Equal(expectedAngle, result);
    }

    [Fact]
    public void HourOffsetPosition_ReturnsHourPlusMinuteDegrees_15()
    {
      int hour = 0;
      int minute = 30;
      int expectedAngle = 15;
      AngleFinder myFinder = new AngleFinder(hour, minute);
      int result = myFinder.HourOffsetPosition();
      Assert.Equal(expectedAngle, result);
    }

  }
}
