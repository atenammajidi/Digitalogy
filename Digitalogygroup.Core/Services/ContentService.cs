using Digitalogygroup.Core.DTOs;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Context;
using Digitalogygroup.DataLayer.Entities.Content;
using Digitalogygroup.DataLayer.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digitalogygroup.Core.Services
{
  public   class ContentService: IContentService
    {
        private DigitalogygroupContext _context;

        public ContentService(DigitalogygroupContext context)
        {
            _context = context;
        }
      
        public int AddNewContent(Item_ContentViewModel NewContent)
        {
            Tbl_content p = new Tbl_content();
            p.Content = NewContent.Content ;
            p.Header  = NewContent.Header ;
            p.Title = NewContent.Title ;
         
            _context.Tbl_content.Add(p);
            _context.SaveChanges();
            return p.Id;
        }

        public Item_ContentViewModel  GetSelectContent(int cid=1)
        {
            return _context.Tbl_content .Where(u => u.Id == cid )
                 .Select(u => new Item_ContentViewModel ()
                 {
                    Title=u.Title ,
                    Content =u.Content ,
                    Header=u.Header ,
                     ID=u.Id ,
                 }).Single();
            //return _context.Tbl_content.Where(u => u.Id  == cid).Single();
        }
        public int EditNewContent(Item_ContentViewModel NewContent)
        {
            Tbl_content p = _context.Tbl_content.Find(NewContent.ID );
  
            p.Content = NewContent.Content;
            p.Header = NewContent.Header;
            p.Title = NewContent.Title;

            _context.Tbl_content.Update(p);
            _context.SaveChanges();
            return p.Id;
        }
        public List<Tbl_content> GetAllContent()
        {
            return _context.Tbl_content.ToList();
        }

        public int AddNewContent(GroupsViewModel.AddNewGroupViewModel NewGoup)
        {
            throw new NotImplementedException();
        }
    }
}
