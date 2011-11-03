using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IAmOpen.Model.Abstractions;
using System.Data;

namespace Iamopen.Controllers
{
    public class InstitutionController : Controller
    {
        private IUnitOfWork unitOfWork;

        //
        // GET: /Institution/

        public InstitutionController(IUnitOfWork unit)
        {
            unitOfWork = unit;
        }

        public ActionResult Index()
        {
            return View(unitOfWork.InstitutionRepository.Get().ToList());
        }

        //
        // GET: /Institution/Details/5

        public ViewResult Details(int id)
        {
            IAmOpen.Model.Models.Institution institution = unitOfWork.InstitutionRepository.GetByID(id);
            return View(institution);
        }

        //
        // GET: /Institution/Create

        public ActionResult Create()
        {
            ViewBag.StatusID = new SelectList(unitOfWork.StatusRepository.Get(), "StatusID", "Name");
            ViewBag.StateID = new SelectList(unitOfWork.StateRepository.Get(), "StateID", "Name");
            ViewBag.ChainID = new SelectList(unitOfWork.ChainRepository.Get(), "ChainID", "Name");
            ViewBag.UserID = new SelectList(unitOfWork.UserRepository.Get(), "UserID", "NickName");
            return View();
        }

        //
        // POST: /Institution/Create

        [HttpPost]
        public ActionResult Create(IAmOpen.Model.Models.Institution institution)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.InstitutionRepository.Insert(institution);
                    //unitOfWork.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            FillStatuses(institution.StatusID);
            FillStates(institution.StateID);
            FillChains(institution.ChainID);
            FillUsers(institution.UserID);
            return View(institution);
        }

        //
        // GET: /Institution/Edit/5

        public ActionResult Edit(int id)
        {
            IAmOpen.Model.Models.Institution institution = unitOfWork.InstitutionRepository.GetByID(id);
            FillStatuses(institution.StatusID);
            FillStates(institution.StateID);
            FillChains(institution.ChainID);
            FillUsers(institution.UserID);
            return View(institution);
        }

        //
        // POST: /Institution/Edit/5

        [HttpPost]
        public ActionResult Edit(IAmOpen.Model.Models.Institution institution)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.InstitutionRepository.Update(institution);
                    unitOfWork.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            FillStatuses(institution.StatusID);
            FillStates(institution.StateID);
            FillChains(institution.ChainID);
            FillUsers(institution.UserID);
            return View(institution);
        }

        //
        // GET: /Institution/Delete/5

        public ActionResult Delete(int id)
        {
            IAmOpen.Model.Models.Institution institution = unitOfWork.InstitutionRepository.GetByID(id);
            return View(institution);
        }

        //
        // POST: /Institution/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            IAmOpen.Model.Models.Institution institution = unitOfWork.InstitutionRepository.GetByID(id);
            unitOfWork.InstitutionRepository.Delete(institution);
            //unitOfWork.Save();
            return RedirectToAction("Index");
        }


        private void FillStatuses(object selectedStatus = null)
        {
            var statuses = unitOfWork.StatusRepository.Get(
                orderBy: q => q.OrderBy(d => d.Name));
            ViewBag.StatusID = new SelectList(statuses, "StatusID", "Name", selectedStatus);
        }

        private void FillStates(object selectedState = null)
        {
            var states = unitOfWork.StateRepository.Get(
                orderBy: q => q.OrderBy(d => d.Name));
            ViewBag.StateID = new SelectList(states, "StateID", "Name", selectedState);
        }

        private void FillChains(object selectedChain = null)
        {
            var chains = unitOfWork.ChainRepository.Get(
                orderBy: q => q.OrderBy(d => d.Name));
            ViewBag.ChainID = new SelectList(chains, "ChainID", "Name", selectedChain);
        }

        private void FillUsers(object selectedUser = null)
        {
            var users = unitOfWork.UserRepository.Get(
                orderBy: q => q.OrderBy(d => d.Nickname));
            ViewBag.ChainID = new SelectList(users, "UserID", "Nickname", selectedUser);
        }
    }
}
