﻿using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Logics
{
    public class PrdManager
    {
        PRN_projectContext context;

        public PrdManager()
        {
            context = new PRN_projectContext();
        }

        public List<Product> getALlProduct(string s)
        {
            context.PublishingHouses.ToList();
            if (s.ToLower().Equals("all"))
                return context.Products.ToList();
            else
            {
                s = s.Trim();
                return context.Products.Where(x => x.ProductName.ToLower().Contains(s.ToLower())
                || x.Publisher.Name.ToLower().Contains(s.ToLower())).ToList();
            }
        }

        public List<Product> getPrdBystatus(int s)
        {
            context.PublishingHouses.ToList();

            if (s == 1 || s == 0)
                return
            context.Products.Where(x => x.Status == s).ToList();
            else
            {

                return context.Products.ToList();
            }
        }

        public Product viewProduct(int id)
        {
            try
            {
                return context.Products.FirstOrDefault(x => x.ProductId == id);
            }
            catch
            {
                return null;
            }
        }

        public List<Category> viewCategoryByPro(int id)
        {
            context.PublishingHouses.ToList();
            context.Categories.ToList();
            try
            {
                List<ProductCategory> list1 = context.ProductCategories.Where(x => x.ProId == id).ToList();
                List<Category> list2 = new List<Category>();
                foreach (ProductCategory cat in list1)
                {
                    Category c = context.Categories.FirstOrDefault(x => x.CatId == cat.CatId);
                    list2.Add(c);
                }
                return list2;
            }
            catch
            {
                return null;
            }
        }

        public List<PublishingHouse> showAllCompany(string par1)
        {
            context.Products.ToList();
            context.PublishingHouses.ToList();
            if (string.IsNullOrEmpty(par1))
                return context.PublishingHouses.ToList();
            else
            {
                par1 = par1.Trim();
                return context.PublishingHouses
                    .Where(x => x.Name.ToLower().Contains(par1.ToLower())
                    || x.Address.ToLower().Contains(par1.ToLower())
                    || x.Phone.ToLower().Contains(par1.ToLower())
                    || x.Url.ToLower().Contains(par1.ToLower())
                    ).ToList();
            }
        }

        public void changeStatus(int id)
        {
            Product p = context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            if (p.Status == 0)
            {
                p.Status = 1;
            }
            else
            {
                p.Status = 0;
            }
            context.Products.Update(p);
            context.SaveChanges();
        }

        public void updateProduct(Product p)
        {
            int a = p.ProductId;
            int? b = p.Quantity;
            context.Products.Update(p);
            context.SaveChanges();
        }

        public PublishingHouse getCompany(int s)
        {
            try
            {
                return context.PublishingHouses.FirstOrDefault(x => x.PublisherId == s);
            }
            catch
            {
                return null;
            }
        }

        public void updateCom(PublishingHouse pub)
        {
            context.PublishingHouses.Update(pub);
            context.SaveChanges();
        }

        public bool isPhone(string s)
        {
            s = s.Trim();
            if (s.Length != 10)
                return false;
            if (context.PublishingHouses.FirstOrDefault(x => x.Phone.Equals(s)) is not null)
                return false;
            foreach(char a in s)
			{
				if (!char.IsDigit(a))
				{
                    return false;
                    break;
				}
			}
            return true;
        }

        public void addPro(Product pub)
        {
            context.Products.Add(pub);
            context.SaveChanges();
        }

        public Admin login(string u, string p)
		{
			try
			{
                return context.Admins.FirstOrDefault(x => x.UserName.Equals(u) && x.Password.Equals(p));
            }
			catch
			{
                return null;
			}
		}

        public List<Category> showAllCat()
        {
            return context.Categories.ToList();
        }

        public List<ProductCategory> getAllCatOfPro(int id = 0)
        {
            return context.ProductCategories.Where(x => x.ProId == id).ToList();
        }

        public void updateCatPro(int proId, List<string> listCate)
        {
            context.ProductCategories.ToList();
            List<ProductCategory> list = context.ProductCategories.Where(x => x.ProId == proId).ToList();
            foreach(ProductCategory cat in list)
            {
                context.ProductCategories.Remove(cat);
                context.SaveChanges();
            }
            foreach(string s in listCate)
            {
                ProductCategory p = new ProductCategory();
                p.ProId = proId;
                p.CatId = Convert.ToInt32(s);
                context.ProductCategories.Add(p);
                context.SaveChanges();
            }
        }

        public void deleteCatPro(int proId)
        {
            context.ProductCategories.ToList();
            Product p = viewProduct(proId);
            if(p is not null)
            {
                List<ProductCategory> list = context.ProductCategories.Where(x => x.ProId == proId).ToList();
                foreach(ProductCategory cat in list)
                {
                    context.ProductCategories.Remove(cat);
                    context.SaveChanges();
                }
            }
        }

        public List<Category> allCategory(string s = "")
        {
            if(string.IsNullOrEmpty(s))
                return context.Categories.ToList();
            else
                return context.Categories.Where( x=> x.CatName.ToLower().Contains(s.ToLower().Trim())
                || x.CatNote.ToLower().Contains(s.ToLower().Trim())).ToList();
        }

        public void deleteCat(int id)
        {
            Category cat = context.Categories.FirstOrDefault(x => x.CatId == id);
            if(cat != null)
            {
                List<ProductCategory> list = context.ProductCategories.Where(x => x.CatId == cat.CatId).ToList();
                if(list.Count > 0)
                {
                    foreach(ProductCategory cat2 in list)
                    {
                        context.ProductCategories.Remove(cat2);
                        context.SaveChanges();
                    }
                }
                context.Categories.Remove(cat);
                context.SaveChanges();
            }
        }

        public Category getCat(int id)
        {
            try
            {
                return context.Categories.FirstOrDefault(x => x.CatId == id);
            }
            catch
            {
                return null;
            }
        }

        public void updateCate(Category c)
        {
            context.Categories.Update(c);
            context.SaveChanges();
        }

        public void changePass(Admin a, string NewPass)
		{
            a.Password = NewPass;
            context.Admins.Update(a);
            context.SaveChanges();
		}

        public List<Product> proOfCompany(int id)
        {
            return context.Products.Where(x => x.PublisherId == id).ToList();
        }
    }
}
