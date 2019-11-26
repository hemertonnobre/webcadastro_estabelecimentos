using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicaçãoEstabelecimento.Controllers
{
    public class EstabelecimentoController : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }

        // GET: Create/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Create/Create
        public ActionResult Create()
        {
            return View();
        }

       
        // GET: Create/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}