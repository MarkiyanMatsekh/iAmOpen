﻿using System;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using System.Data;
using IAmOpen.Site.Model.Abstractions;
using IAmOpen.Site.Model.Concrete.Database;
using IAmOpen.Site.Model.Models;
using Iamopen.Availability.OnlineAvailability.Implementation;
using Iamopen.Availability.OnlineAvailability.Interface.Models;

namespace Iamopen.Site.Controllers
{
    public class InstitutionController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

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
            Institution institution = unitOfWork.InstitutionRepository.GetByID(id);
            return View(institution);
        }

        //
        // GET: /Institution/Create

        public ActionResult Create()
        {
            ViewBag.StatusID = new SelectList(unitOfWork.StatusRepository.Get(), "ID", "Name");
            ViewBag.StateID = new SelectList(unitOfWork.StateRepository.Get(), "ID", "Name");
            ViewBag.ChainID = new SelectList(unitOfWork.ChainRepository.Get(), "ID", "Name");
            ViewBag.UserID = new SelectList(unitOfWork.UserRepository.Get(), "ID", "NickName");
            return View();
        }

        //
        // POST: /Institution/Create

        [HttpPost]
        public ActionResult Create(Institution institution)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.InstitutionRepository.Insert(institution);
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
        // GET: /Institution/Edit/5

        public ActionResult Edit(int id)
        {
            // MM: example calling stored procedure

            //using (InstitutionContext context = new InstitutionContext())
            //{
            //    var c = context.Database.SqlQuery<Institution>("TestProc @InstitutionID",
            //        new SqlParameter("InstitutionID", 3));
            //    var f = c.ToList();
            //}
            
            Institution institution = unitOfWork.InstitutionRepository.GetByID(id);
            FillStatuses(institution.StatusID);
            FillStates(institution.StateID);
            FillChains(institution.ChainID);
            FillUsers(institution.UserID);
            return View(institution);
        }

        //
        // POST: /Institution/Edit/5

        [HttpPost]
        public ActionResult Edit(Institution institution)
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
            Institution institution = unitOfWork.InstitutionRepository.GetByID(id);
            return View(institution);
        }

        //
        // POST: /Institution/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Institution institution = unitOfWork.InstitutionRepository.GetByID(id);
            unitOfWork.InstitutionRepository.Delete(institution);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }


        public ActionResult OnlineAvailability(int id)
        {
            InstitutionOnlineStatusRequestResult data;
            using (var reservationManager = new OnlineAvailabilityManager())
            {
                // note MM: very serious bug fixed. concerning dll Hell. 
                // When invoking context.Database.SqlQuery<>() ... from assemly IAmOpen.Common AccessViolation was thrown 
                // this was because this assembly had a reference to EntityFramework.dll , v4.0, and all others had v4.1 with support of sql queries
                // If anything similar happens - change reference of a library to a local copy (in lib folder)
                
                // now, stored procedures are safely invoked, but still with few bugs, that dont let use this funcitonality

                //var d = reservationManager.ReserveTable(new ReservationInfo()
                //                                            {
                //                                                TableID = 5,
                //                                                UserInfo = new UserInfo() { UserSID = 1 },
                //                                                ReservationTime = DateTime.Now
                //                                            });


                data = reservationManager.GetInstitutionOnlineStatus(
                       new InstitutionOnlineStatusRequestInfo
                       {
                           InstitutionID = id
                       });
            }
            return View(data);
        }


        private void FillStatuses(object selectedStatus = null)
        {
            var statuses = unitOfWork.StatusRepository.Get(
                orderBy: q => q.OrderBy(d => d.Name));
            ViewBag.StatusID = new SelectList(statuses, "ID", "Name", selectedStatus);
        }

        private void FillStates(object selectedState = null)
        {
            var states = unitOfWork.StateRepository.Get(
                orderBy: q => q.OrderBy(d => d.Name));
            ViewBag.StateID = new SelectList(states, "ID", "Name", selectedState);
        }

        private void FillChains(object selectedChain = null)
        {
            var chains = unitOfWork.ChainRepository.Get(
                orderBy: q => q.OrderBy(d => d.Name));
            ViewBag.ChainID = new SelectList(chains, "ID", "Name", selectedChain);
        }

        private void FillUsers(object selectedUser = null)
        {
            var users = unitOfWork.UserRepository.Get(
                orderBy: q => q.OrderBy(d => d.Nickname));
            ViewBag.ChainID = new SelectList(users, "ID", "Nickname", selectedUser);
        }
    }
}
