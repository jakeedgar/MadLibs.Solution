using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/output")]
    public ActionResult OutputMadLibs(string personOne, string personTwo, string noun, string verb, string adjective)
    {
      InputMadLibs myMadLibs = new InputMadLibs();
      myMadLibs.PersonOne = personOne;
      myMadLibs.PersonTwo = personTwo;
      myMadLibs.Noun = noun;
      myMadLibs.Verb = verb;
      myMadLibs.Adjective = adjective;
      return View(myMadLibs);
    }
  }
}