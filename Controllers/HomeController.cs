using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers //be sure to use your own project's namespace!
{
    public class HomeController: Controller //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet] //type of request
        [Route("")] //associated route string (exclude the leading /)
        public string Index() 
        {
            return "Hello World from My Index! HomeController.cs";
        }
        [HttpGet] //type of request
        [Route("projects")] //associated route string (exclude the leading /)
        public string projects() 
        {
            return "These are my projects! HomeController.cs";
        }
        [HttpGet] //type of request
        [Route("contact")] //associated route string (exclude the leading /)        
        public string contact() 
        {
            return "This is my contact! HomeController.cs";
        }
    }
}