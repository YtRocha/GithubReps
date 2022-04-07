using Microsoft.AspNetCore.Mvc;
using GithubReps.Models;
using Octokit;


namespace GithubReps.Controllers
{
    public class MeusRepositorios : Controller
    {
        /*
            myReps retorna a lista de repositorios do usuario YtRocha.
         */
        public IReadOnlyList<Repository> myReps()
        {
            var client = new GitHubClient(new ProductHeaderValue("GithubReps"));
            var reps = Task.Run(async() => await client.Repository.GetAllForUser("YtRocha")).Result;

            return reps;
        }

        public IActionResult Index()
        {
           
                
            return View(myReps()); 
        }

    }
}
