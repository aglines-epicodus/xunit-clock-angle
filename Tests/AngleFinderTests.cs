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
  }
}
