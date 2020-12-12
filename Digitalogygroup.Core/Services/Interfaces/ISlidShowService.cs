using Digitalogygroup.Core.DTOs;
using Digitalogygroup.DataLayer.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalogygroup.Core.Services.Interfaces
{
   public  interface ISlidShowService
    {
        int AddNewSlidShow(ADDItem_SlideShowViewModel NewGoup);
        Item_SlideShowViewModel GetSelectSlidShow(int cid = 1);
        void EditNewSlidShow(Item_SlideShowViewModel NewSlidShow);
        List<Tbl_SlidShow> GetAllSlidShow();
        List<Tbl_SlidShow> GetSlidShow_Parent (int g =1);
    }
}
