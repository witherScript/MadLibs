using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Landing()
    {
      return View();
    } 

    [Route("/scifi-form")]
    public ActionResult SciFiForm()
    {
      return View();
    }

    //scifi-form path
    [Route("/scifi")]
    public ActionResult SciFi(StoryParameters words)
    {
      Story sciFiStory = new Story(words);
      return View(sciFiStory);
    }

    [Route("/fantasy-form")]
    public ActionResult FantasyForm() 
    {
      return View();
    }

    [Route("/fantasy")]
    public ActionResult Fantasy(StoryParameters words)
    {
      Story fantasyStory = new Story(words);
      return View(fantasyStory);
    }
     [Route("/action-form")]
    public ActionResult ActionForm()
    {
      return View();
    }
    [Route("/action")]
    public ActionResult Action(StoryParameters words)
    {
      Story ActionStory = new Story(words);
      return View(ActionStory);
    }

    //todo: HorrorForm View

    [Route("/horror-form")]
    public ActionResult HorrorForm()
    {
      return View();
    } 

    [Route("/horror")]
    public ActionResult Horror(StoryParameters words)
    {
      Story HorrorStory = new Story(words);
      return View(HorrorStory);
    }
  } 
}