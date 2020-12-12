using Digitalogygroup.Core.DTOs;
using Digitalogygroup.Core.Generator;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Context;
using Digitalogygroup.DataLayer.Entities.Products;
using Digitalogygroup.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static Digitalogygroup.Core.DTOs.GroupsViewModel;

namespace Digitalogygroup.Core.Services
{
    public class GroupService : IGroupService
    {

        private DigitalogygroupContext _context;

        public GroupService(DigitalogygroupContext context)
        {
            _context = context;
        }

        public int AddNewGroupInDB(GroupsViewModel.AddNewGroupViewModel NewGoup)
        {
            Tbl_ProductGroup gp = new Tbl_ProductGroup();
            gp.GroupTitle = NewGoup.GroupTitle;
            gp.priority = int.Parse(NewGoup.priority);
            gp.IsActive = NewGoup.IsActive;
            gp.FK_Parent = int.Parse(NewGoup.FK_Parent);
            _context.Tbl_ProductGroup.Add(gp);
            _context.SaveChanges();
            return gp.Id;
        }

        public int AddNewProductInDB(AddNewProductViewModel NewProduct)
        {
            Tbl_Product p = new Tbl_Product();
            p.ProductTitle = NewProduct.ProductTitle;
            p.IsActive = NewProduct.IsActive;
            p.ProductFullDesc = NewProduct.ProdFullDesc;
            p.ProductShortDesc = NewProduct.ProdShortDesc;
            p.FK_Language = int.Parse(NewProduct.FK_Language);
            p.FK_ProductGroup = int.Parse(NewProduct.FK_Group);
            p.RegisterDate = DateTime.Now;

            #region Save Pic

            if (NewProduct.pic != null)
            {
                string imagePath = "";
                p.ProductImg = NameGenerator.GenerateUniqCode() + Path.GetExtension(NewProduct.pic.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProductPics", p.ProductImg);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    NewProduct.pic.CopyTo(stream);
                }
            }

            #endregion

            _context.Tbl_Product.Add(p);
            _context.SaveChanges();
            return p.Id;
        }

        public List<Tbl_ProductGroup> GetActiveProductGroup()
        {
            return _context.Tbl_ProductGroup.Where(u=> u.IsActive==true).ToList();
        }

        public List<Tbl_ProductGroup> GetProductGroup()
        {
            return _context.Tbl_ProductGroup.ToList();
        }

        public List<AllProductList> ShowAllProduct()
        {
            return _context.Tbl_Product
              .Select(u => new AllProductList()
              {
                  GroupTitle = _context.Tbl_ProductGroup.Single(z => z.Id == u.FK_ProductGroup).GroupTitle,
                  Language= _context.Tbl_Language.Single(z => z.Id == u.FK_Language).LanguageTitle,
                  ProdID = u.Id,
                  ProductTitle=u.ProductTitle,
                  ProdShortDesc=u.ProductShortDesc,
                  RegisterDate=u.RegisterDate,
                  IsActive = u.IsActive,
              }).ToList();
        }

        public GroupsViewModel.EditGroupViewModel ShowGroupForEditMode(int GroupID)
        {


            return _context.Tbl_ProductGroup.Where(u => u.Id == GroupID)
               .Select(u => new EditGroupViewModel()
               {
                   GroupID = u.Id,
                   GroupTitle = u.GroupTitle,
                   priority = u.priority.ToString(),
                   FK_Parent = u.FK_Parent.ToString(),
                   IsActive = u.IsActive,
               }).Single();
        }

        public EditProductViewModel ShowProductForEditMode(int ProductID)
        {
            return _context.Tbl_Product.Where(u => u.Id == ProductID)
                          .Select(u => new EditProductViewModel()
                          {
                              ProdID = u.Id,
                              FK_Group = u.FK_ProductGroup,
                              FK_Language= _context.Tbl_Language.Single(z => z.Id == u.FK_Language).LanguageTitle,
                              ProductTitle = u.ProductTitle,
                              ProdFullDesc = u.ProductFullDesc,
                              ProdShortDesc = u.ProductShortDesc,
                              IsActive = u.IsActive,
                              picName=u.ProductImg
                          }).Single();
        }

        public void UpdateGroup(EditGroupViewModel GP)
        {
            Tbl_ProductGroup x = _context.Tbl_ProductGroup.Find(GP.GroupID);

            x.GroupTitle = GP.GroupTitle;
            x.IsActive = GP.IsActive;
            x.priority = int.Parse(GP.priority);
           
            _context.Tbl_ProductGroup.Update(x);
            _context.SaveChanges();
        }

        public void UpdateProduct(EditProductViewModel EditProduct)
        {
            Tbl_Product x = _context.Tbl_Product.Find(EditProduct.ProdID);

            x.ProductTitle = EditProduct.ProductTitle;
            x.ProductFullDesc = EditProduct.ProdFullDesc;
            x.ProductShortDesc = EditProduct.ProdShortDesc;
            x.IsActive = EditProduct.IsActive;

            if (EditProduct.pic != null)
            {
                //Delete old Image
                if (EditProduct.picName != "Defult.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProductPics", EditProduct.picName);
                    if (File.Exists(deletePath))
                    {
                        File.Delete(deletePath);
                    }
                }

                //Save New Image
                x.ProductImg = NameGenerator.GenerateUniqCode() + Path.GetExtension(EditProduct.pic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProductPics", x.ProductImg);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    EditProduct.pic.CopyTo(stream);
                }
            }

            _context.Tbl_Product.Update(x);
            _context.SaveChanges();
        }
    }
}
