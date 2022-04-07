using Microsoft.AspNetCore.Mvc;
using Octokit;

namespace GithubReps.Controllers
{
    public class Repositorios : Controller
    {

        /*
            repositorio recebe um usuario do github e um nome de repositorio para
            retorna um objeto pertencente a classe Octokit.Repository
         */
        public Repository repositorio(string gitHubUser, string repName)
        {
            var client = new GitHubClient(new ProductHeaderValue("GithubReps"));
            var rep = Task.Run(async () => await client.Repository.Get(gitHubUser, repName)).Result;
          
            return rep;
        }
        
        public IActionResult RepositorioSelecionado(string rep)
        {
            string gitHubUser = rep.Split('/')[0];
            string repName = rep.Split('/')[1];

            return View(repositorio(gitHubUser, repName));
        }
        

        
    }
}
