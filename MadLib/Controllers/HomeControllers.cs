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
    public ActionResult Form(StoryParameters words) 
    {
      return View();
    }

    [Route("/fantasy")]
    public ActionResult Fantasy(StoryParameters words)
    {
      Story fantasyStory = new Story(words);
      return View(fantasyStory);
    }
     [Route("/Action-form")]
    public ActionResult
  }
}