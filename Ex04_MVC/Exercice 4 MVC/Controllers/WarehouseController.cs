﻿using Exercice_4_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Exercice_4_MVC.Controllers
{
    public class WarehouseController : Controller
    {
        public static List<Warehouse> Warehouses { get; set; }

        public WarehouseController()
        {
            if(WarehouseController.Warehouses == null)
            {
                WarehouseController.Warehouses = new List<Warehouse>()
                {
                    new Warehouse()
                    {
                        Id = 1,
                        Name = "Entrepot de Paris",
                        Address = "10 rue du csharp",
                        PostalCode = 75000
                    },
                    new Warehouse()
                    {
                        Id = 2,
                        Name = "Entrepot de Nantes",
                        Address = "15 rue de .net",
                        PostalCode = 44300
                    }
                };
            }
            
        }

        // GET: WarehouseController
        public ActionResult Index()
        {
            return View(WarehouseController.Warehouses);
        }

        // GET: WarehouseController/Details/5
        public ActionResult Details(int id)
        {
            // Search throught warehouses list the target warehouse by id
            var foundWarehouse = WarehouseController.Warehouses.FirstOrDefault(w => w.Id == id);

            return View(foundWarehouse);
        }

        // GET: WarehouseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WarehouseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                //int newId = WarehouseController.Warehouses.Select(w => w.Id).Aggregate((previusMax, current) => { return Math.Max(previusMax, current); }) + 1;
                Warehouse warehouse = new Warehouse();
                ApplyFormCollectionToWarehouse(collection, warehouse);
                WarehouseController.Warehouses.Add(warehouse);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WarehouseController/Edit/5
        public ActionResult Edit(int id)
        {
            // Search throught warehouses list the target warehouse by id
            var foundWarehouse = WarehouseController.Warehouses.FirstOrDefault(w => w.Id == id);

            return View();
        }

        // POST: WarehouseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // Search throught warehouses list the target warehouse by id
                var foundWarehouse = WarehouseController.Warehouses.FirstOrDefault(w => w.Id == id);
                if (foundWarehouse is null)
                {
                    throw new Exception();
                }
                ApplyFormCollectionToWarehouse(collection, foundWarehouse);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private void ApplyFormCollectionToWarehouse(IFormCollection collection, Warehouse foundWarehouse)
        {
            foreach (var field in collection)
            {
                if (field.Key == nameof(foundWarehouse.Id))
                {
                    foundWarehouse.Id = int.Parse(field.Value);
                }
                else if (field.Key == nameof(foundWarehouse.Name))
                {
                    foundWarehouse.Name = field.Value;
                }
                else if (field.Key == nameof(foundWarehouse.Address))
                {
                    foundWarehouse.Address = field.Value;
                }
                else if (field.Key == nameof(foundWarehouse.PostalCode))
                {
                    foundWarehouse.PostalCode = int.Parse(field.Value);
                }
            }
        }

        // GET: WarehouseController/Delete/5
        public ActionResult Delete(int id)
        {
            // Search throught warehouses list the target warehouse by id
            var foundWarehouse = WarehouseController.Warehouses.FirstOrDefault(w => w.Id == id);

            return View(foundWarehouse);
        }

        // POST: WarehouseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // Search throught warehouses list the target warehouse by id
                var foundWarehouse = WarehouseController.Warehouses.FirstOrDefault(w => w.Id == id);
                if(foundWarehouse != null)
                {
                    WarehouseController.Warehouses.Remove(foundWarehouse);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
