﻿using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;
using ProductManager.Logics;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        PrdManager dao = new PrdManager();
        public IActionResult Index(string par1 = "all", int par2=0)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }
            ViewBag.user = getUserName();
            ViewBag.here = "pro";

            if(string.IsNullOrEmpty(par1))
                par1 = "all";
            if (par2 <= 0)
                ViewBag.curPage = 1;
            else if (par2 > paging(par1))
            {
                par2 = paging(par1);
                ViewBag.curPage = par2;
            }
            else
                ViewBag.curPage = par2;

            List<Product> products = dao.getALlProduct(par1).Skip((par2 - 1) * 5).Take(5).ToList();

            if (String.IsNullOrEmpty(par1))
                ViewBag.seacrh = "all";
            else
                ViewBag.seacrh = par1;
            ViewBag.allPage = paging(par1);

            List<PublishingHouse> allCom = dao.showAllCompany("");
            ViewBag.allCom = allCom;
            return View(products);
        }

        public IActionResult detail(int par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "pro";
            Product p = dao.viewProduct(par1);
            List<Category> cat = dao.viewCategoryByPro(par1);
            ViewBag.cate = cat;
            ViewBag.IDate = p.ImportDate?.ToString("dd/MM/yyyy");
            return View(p);
        }

        public IActionResult status(int par1, string par2)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            Product pr = dao.viewProduct(par1);
            dao.changeStatus(par1);
            List<Product> products = dao.getALlProduct(pr.ProductName);
            ViewBag.here = "pro";
            ViewBag.seacrh = pr.ProductName;

            List<PublishingHouse> allCom = dao.showAllCompany("");
            ViewBag.allCom = allCom;

            return View("/views/product/index.cshtml", products);
        }

        public IActionResult quantity(Product upPro)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            Product pr = dao.viewProduct(upPro.ProductId);
            pr.Quantity = upPro.Quantity;
            if (pr.Quantity > 0)
            {
                dao.updateProduct(pr);
            }
            if (pr.Quantity == 0)
            {
                pr.Status = 0;
                dao.updateProduct(pr);
            }
            if (pr.Quantity < 0)
            {

                return RedirectToAction("index", "product");
            }
            List<Product> products = dao.getALlProduct(pr.ProductName);
            ViewBag.here = "pro";
            ViewBag.seacrh = pr.ProductName;
            return RedirectToAction("index", "product");
        }

        public IActionResult listStatus(int par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "pro";
            ViewBag.seacrh = "";
            ViewBag.stt = par1;
            List<Product> products = dao.getPrdBystatus(par1);
            List<PublishingHouse> allCom = dao.showAllCompany("");
            ViewBag.allCom = allCom;
            if (par1 == 0 || par1 == 1)
                return View(products);
            else
                return RedirectToAction("index");
        }

        public IActionResult update(int par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "pro";
            ViewBag.ok = 1;
            ViewBag.mess = "Please check your work before you submit";
            List<PublishingHouse> pub = dao.showAllCompany("");
            ViewBag.pub = pub;
            Product p = dao.viewProduct(par1);
            ViewBag.cat = dao.showAllCat();
            ViewBag.catPr = dao.getAllCatOfPro(par1);
            ViewBag.check = "checked";
            return View(p);
        }

        public IActionResult doupdate(Product updatePr)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "pro";
            Product p = updatePr;
            if (updatePr.Status > 0 && updatePr.Quantity <= 0)
            {
                ViewBag.ok = 0;
                ViewBag.mess = "Your work has something not right... pls check again :< ";
            }
            else
            {
                ViewBag.ok = 1;
                dao.updateProduct(updatePr);
                ViewBag.mess = "Your work has done successfully";
            }
            ViewBag.pub = dao.showAllCompany("");
            string a = Request.Form["cate"];
            List<string> list = new List<string>();
            if (!string.IsNullOrEmpty(a))
            {
                string[] words = a.Split(',');
                foreach (string w in words)
                {
                    list.Add(w.Trim());
                }
                dao.updateCatPro(updatePr.ProductId, list);
            }
            else
            {
                dao.deleteCatPro(updatePr.ProductId);
            }
            ViewBag.cat = dao.showAllCat();
            ViewBag.catPr = dao.getAllCatOfPro(updatePr.ProductId);
            ViewBag.check = "checked";

            return View("/views/product/update.cshtml", p);
        }

        public IActionResult add()
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "pro";
            ViewBag.act = "doadd";
            ViewBag.ok = 1;
            ViewBag.mess = "Please check your work before you submit";
            List<PublishingHouse> pub = dao.showAllCompany("");
            ViewBag.pub = pub;
            Product p = new Product();
            p.ImportDate = DateTime.Now;
            ViewBag.cat = dao.showAllCat();
            ViewBag.catPr = dao.getAllCatOfPro();
            ViewBag.check = "checked";
            return View("/views/product/update.cshtml", p);
        }

        public IActionResult doadd(Product updatePr)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "pro";
            Product p = updatePr;
            if (updatePr.Status > 0 && updatePr.Quantity <= 0)
            {
                ViewBag.ok = 0;
                ViewBag.mess = "Your work has something not right... pls check again :< ";
            }
            else
            {
                ViewBag.ok = 1;
                dao.addPro(updatePr);
                ViewBag.mess = "Your work has done successfully";
            }
            string a = Request.Form["cate"];
            List<string> list = new List<string>();
            if (!string.IsNullOrEmpty(a))
            {
                string[] words = a.Split(',');
                foreach (string w in words)
                {
                    list.Add(w.Trim());
                }
                dao.updateCatPro(updatePr.ProductId, list);
            }
            else
            {
                //   dao.deleteCatPro(updatePr.ProductId);
            }

            ViewBag.cat = dao.showAllCat();
            ViewBag.catPr = dao.getAllCatOfPro(updatePr.ProductId);
            ViewBag.check = "checked";
            ViewBag.pub = dao.showAllCompany("");
            return View("/views/product/update.cshtml", p);
        }

        public IActionResult login()
        {
            Admin a = new Admin();
            string user = Request.Cookies["username"];
            string pass = Request.Cookies["password"];
            if (!string.IsNullOrEmpty(user))
                a.UserName = user;
            if (!string.IsNullOrEmpty(pass))
                a.Password = pass;
            string? checkbox = Request.Cookies["rem"];
            ViewBag.rem = checkbox;
            return View(a);
        }

        public IActionResult dologin(Admin adm)
        {
            Admin ad = dao.login(adm.UserName, adm.Password);
            if (ad is null)
            {
                ViewBag.mess = "Check you input again please";
                return View("views/product/login.cshtml", adm);
            }
            else
            {
                string user = JsonConvert.SerializeObject(ad);
                HttpContext.Session.SetString("user", user);
                // chay cookie 
                string? remember = Request.Form["rem"];
                if (string.IsNullOrEmpty(remember))
                    remember = "";
                if (remember.Equals("true"))
                {
                    Response.Cookies.Append("rem", "checked");
                    Response.Cookies.Append("username", adm.UserName);
                    Response.Cookies.Append("password", adm.Password);
                }
                return RedirectToAction("index");
            }
        }

        public IActionResult logout()
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            HttpContext.Session.Remove("user");
            return RedirectToAction("login");
        }

        public bool checkLogin()
        {
            string? user = HttpContext.Session.GetString("user");
            if (string.IsNullOrEmpty(user))
                return false;
            else
                return true;
        }

        public string getUserName()
        {
            string? user = HttpContext.Session.GetString("user");
            if (string.IsNullOrEmpty(user))
                return "";
            else
            {
                Admin ad = JsonConvert.DeserializeObject<Admin>(user);
                return ad.FullName;
            }
        }

        public int paging(string par1)
        {
            List<Product> products = dao.getALlProduct(par1);
            int page;
            if (products.Count % 5 == 0)
                page = products.Count / 5;
            else
                page = products.Count / 5 + 1;
            return page;
        }
    }
}
