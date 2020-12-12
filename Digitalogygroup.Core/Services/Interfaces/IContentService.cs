using Digitalogygroup.Core.DTOs;
using Digitalogygroup.DataLayer.Entities.Content;
using Digitalogygroup.DataLayer.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalogygroup.Core.Services.Interfaces
{
  public interface IContentService
    {

        int AddNewContent(Item_ContentViewModel NewGoup);
       Item_ContentViewModel  GetSelectContent(int cid=1);
        int EditNewContent(Item_ContentViewModel NewContent);
        List<Tbl_content> GetAllContent();

    }
}
