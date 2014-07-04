﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlViaticosApp.Models;

namespace ControlViaticosApp.Controllers
{
    public class ViaticosController : Controller
    {

        private List<Viaticos> CrearViaticos()
    {
        List<Viaticos> viaticos = new List<Viaticos>();
        viaticos.Add(new Viaticos() { Codigo = 1, ApellidosNombres = "Alvaro Castro Roman", Cargo = "Ejecutivo Ventas", Area = "Ventas", CentroCosto = "14345", JustificacionViaje = "Firma de contrato de crédito", LugarPartida = "Lima", LugarDestino = "Piura", FomaPago = "Efectivo", NumeroDias = 5, MontoViaticoDiario = 120, MontoTotal = 600, Estado = "Aprobado" });
        viaticos.Add(new Viaticos() { Codigo = 2, ApellidosNombres = "Moreno Valvede Maria", Cargo = "Ejecutivo Cuenta", Area = "Ventas", CentroCosto = "14345", JustificacionViaje = "Firma de contrato de crédito", LugarPartida = "Lima", LugarDestino = "Cuzco", FomaPago = "Deposito Bancario", NumeroDias = 3, MontoViaticoDiario = 100, MontoTotal = 300, Estado = "Desaprobado" });
        viaticos.Add(new Viaticos() { Codigo = 3, ApellidosNombres = "Salazar Mendieta Hugo", Cargo = "Ejecutivo Negocio", Area = "Comercial", CentroCosto = "89876", JustificacionViaje = "Venta de productos", LugarPartida = "Lima", LugarDestino = "Arequipa", FomaPago = "Efectivo", NumeroDias = 2, MontoViaticoDiario = 85, MontoTotal = 170, Estado = "Aprobado" });
        viaticos.Add(new Viaticos() { Codigo = 4, ApellidosNombres = "Sanchez Velez Andrés", Cargo = "Ejecutivo Ventas", Area = "Ventas", CentroCosto = "14345", JustificacionViaje = "Firma de contrato de crédito", LugarPartida = "Tacna", LugarDestino = "Lima", FomaPago = "Efectivo", NumeroDias = 4, MontoViaticoDiario = 90, MontoTotal = 360, Estado = "Pendiente" });

        return viaticos;
    }
        //
        // GET: /Viaticos/

        public ActionResult Index()
        {
            if(Session["viaticos"] == null)
                Session["viaticos"] = CrearViaticos();
            List<Viaticos> model = (List<Viaticos>) Session["viaticos"]; 
            return View(model);
        }

        //
        // GET: /Viaticos/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Viaticos/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Viaticos/Create

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
        // GET: /Viaticos/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Viaticos/Edit/5

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
        // GET: /Viaticos/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Viaticos/Delete/5

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