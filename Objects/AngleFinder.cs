using System.Collections.Generic;
using System;

namespace ClockAngle
{
  public class AngleFinder
  {
    private int _hour;
    private int _minute;
    public AngleFinder(int hour, int minute)
    {
      _hour = hour;
      _minute = minute;
    }

    public int MinutePosition()
    {
      // output: an int, 360 divided by 30
      return _minute * 6;
    }

    public int HourPosition()
    {
      return _hour * 30 ;
    }

    public int HourOffsetPosition()
    {
      return _minute / 2;
    }
  }
}
