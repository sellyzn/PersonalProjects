using LearnASPNETMVCWitheRealApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnASPNETMVCWitheRealApps.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }
        public ActionResult Buy(string id)
        {
            ProductModel productModel = new ProductModel();
            //如果购物车为空，将所选商品创建新的Item，加入购物车，通过在productModel中查找id，并将数量设置为1
            //否则
            //      如果购物车已存在所选商品（查看id），将对应商品的数量+1.
            //      
            if(Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = productModel.Find(id), Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = IsExist(id);
                if(index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = productModel.Find(id), Quantity = 1 });
                }
            }
            return RedirectToAction("Index");
        }

        //删除对应id的商品
        public ActionResult Remove(string id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            int index = IsExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");     ////?????????????
        }
     
        public int IsExist(string id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                    return i;
            }
            return -1;
        }
    }
}