using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TC_WebShopCaseMVC.Entities;

namespace TC_WebShopCaseMVC.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/
        public ActionResult Index(int? pageNumber, int? pageSize)
        {
            if (!pageNumber.HasValue)
                pageNumber = 1;

            if (!pageSize.HasValue)
                pageSize = 10;

            var reader = new XMLReader(HttpContext.Server.MapPath("~/App_Data"));
            var articles = reader.GetArticles().Skip((pageNumber.Value - 1) * pageSize.Value).Take(pageSize.Value);

            return View(articles);
        }

        //
        // GET: /Article/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Article/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Article/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Article/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Article/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Article/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Article/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
