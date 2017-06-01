using Nancy;
using System.Collections.Generic;
using System;

namespace ClockAngle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => "Hello world";
    }
  }
}
