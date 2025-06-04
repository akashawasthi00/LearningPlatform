using PlatformServices;
using System.Web.Mvc;

public class TutorialController : Controller
{
    private readonly ITutorialService _tutorialService;

    public TutorialController(ITutorialService tutorialService)
    {
        _tutorialService = tutorialService;
    }

    public ActionResult Courses()
    {
        ViewBag.ShowSidebar = false;
        return View();
    }

    public ActionResult Start()
    {
        ViewBag.Title = "Courses";
       
        return View();
    }

    public ActionResult Index(string courseName)
    {
        if (string.IsNullOrEmpty(courseName))
        {
            courseName = "Linux";
        }
        else
        {
            courseName = courseName.Trim();
        }

        var topics = _tutorialService.GetTopicsByCourse(courseName);
        ViewBag.CourseName = courseName;
        ViewBag.ShowSidebar = true; // Show sidebar on Index
        return View(topics);
    }

    public ActionResult Content(int? topicId)
    {
        if (!topicId.HasValue)
        {
            return RedirectToAction("Index", new { courseName = "Linux" });
        }

        var content = _tutorialService.GetContentByTopicId(topicId.Value);
        var courseName = "Linux".Trim();
        ViewBag.Topics = _tutorialService.GetTopicsByCourse(courseName);
        ViewBag.SelectedTopicId = topicId;
        ViewBag.CourseName = courseName;
        ViewBag.ShowSidebar = true; // Show sidebar on Content
        return View(content);
    }


}