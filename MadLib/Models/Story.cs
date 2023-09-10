namespace MadLibs.Models
{
  public class Story
  {
    public StoryParameters Words{get; set;}
    public Story(StoryParameters parameters)
    {
      this.Words = parameters; 
    }
  }
}