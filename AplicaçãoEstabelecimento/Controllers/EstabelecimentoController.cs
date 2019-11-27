using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoEstabelecimento.Controllers
{
    public class EstabelecimentoController : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }

        // GET: Create/Details/5
        [Route("Details/{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Create/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }


        // GET: Create/Edit/5
        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}