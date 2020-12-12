using Digitalogygroup.Core.DTOs;
using Digitalogygroup.Core.Generator;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Context;
using Digitalogygroup.DataLayer.Entities.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Digitalogygroup.Core.Services
{
  public   class SlidShowService :ISlidShowService
    {
        private DigitalogygroupContext _context;

        public SlidShowService(DigitalogygroupContext context)
        {
            _context = context;
        }

        public int AddNewSlidShow(ADDItem_SlideShowViewModel NewSlidShow)
        {
            Tbl_SlidShow p = new Tbl_SlidShow();
            p.Title  = NewSlidShow.Title ;
            p.Link  = NewSlidShow.Link ;
            p.Parent  = NewSlidShow.Parent ;
           
            #region Save Pic

            if (NewSlidShow .ImageUrl != null)
            {
                string imagePath = "";
                p.ImageUrl  = NameGenerator.GenerateUniqCode() + Path.GetExtension(NewSlidShow .ImageUrl .FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Slid", p.ImageUrl );
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    NewSlidShow .ImageUrl .CopyTo(stream);
                }
            }

            #endregion

            _context.tbl_SlidShow.Add(p);
            _context.SaveChanges();
            return p.Id;
        }

        public Item_SlideShowViewModel GetSelectSlidShow(int cid = 1)
        {
            return _context.tbl_SlidShow.Where(u => u.Id == cid)
                 .Select(u => new Item_SlideShowViewModel()
                 {
                     Title = u.Title,
                     picName   = u.ImageUrl,
                     Parent = u.Parent ,
                     Link  = u.Link ,
                     Id=u.Id,
                 }).Single();
            //return _context.Tbl_SlidShow.Where(u => u.Id  == cid).Single();
        }
        public void EditNewSlidShow(Item_SlideShowViewModel NewSlidShow)
        {
            Tbl_SlidShow p = _context.tbl_SlidShow.Find(NewSlidShow.Id);

            p.Link = NewSlidShow.Link;
            p.Parent = NewSlidShow.Parent;
            p.Title = NewSlidShow.Title;

            if (NewSlidShow.ImageUrl  != null)
            {
                //Delete old Image
                if (NewSlidShow.picName != "Defult.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Slid", NewSlidShow.picName);
                    if (File.Exists(deletePath))
                    {
                        File.Delete(deletePath);
                    }
                }

                //Save New Image
                p.ImageUrl  = NameGenerator.GenerateUniqCode() + Path.GetExtension(NewSlidShow.ImageUrl.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Slid", p.ImageUrl);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    NewSlidShow .ImageUrl .CopyTo(stream);
                }
            }

            _context.tbl_SlidShow.Update(p);
            _context.SaveChanges();

        }
        public List<Tbl_SlidShow> GetAllSlidShow()
        {
            return _context.tbl_SlidShow.ToList ();
        }
        public List<Tbl_SlidShow> GetSlidShow_Parent (int pare=1)
        {
            return _context.tbl_SlidShow.Where (p => p.Parent==pare ).ToList();
        }
    }
}
