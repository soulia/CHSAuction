using CHSAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHSAuction.Controllers
{
    public class BidsController : Controller
    {
        // GET: Bids
        public ActionResult Index()
        {
            var model =
                from i in _bids
                orderby i.Id
                select i;

            return View(model);
        }

        // GET: Bids/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bids/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bids/Create
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

        // GET: Bids/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bids/Edit/5
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

        // GET: Bids/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bids/Delete/5
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

        static List<ItemBid> _bids = new List<ItemBid>
        {
            new ItemBid {
                Id = 1,
                Bid = 1,
                ItemId = 1,
                UserId = 1
            },            
            new ItemBid {
                Id = 2,
                Bid = 2,
                ItemId = 2,
                UserId = 1
            },            
            new ItemBid {
                Id = 3,
                Bid = 3,
                ItemId = 3,
                UserId = 1
            }
        };
    }
}
