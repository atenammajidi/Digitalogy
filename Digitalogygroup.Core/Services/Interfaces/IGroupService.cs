using Digitalogygroup.DataLayer.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using static Digitalogygroup.Core.DTOs.GroupsViewModel;

namespace Digitalogygroup.Core.Services.Interfaces
{
   public interface IGroupService
    {

        List<Tbl_ProductGroup> GetProductGroup();
        List<Tbl_ProductGroup> GetActiveProductGroup();


        int AddNewGroupInDB(AddNewGroupViewModel NewGoup);


        EditGroupViewModel ShowGroupForEditMode(int GroupID);

        void UpdateGroup(EditGroupViewModel GP);


        List<AllProductList> ShowAllProduct();

        int AddNewProductInDB(AddNewProductViewModel NewProduct);


        EditProductViewModel ShowProductForEditMode(int ProductID);

        void UpdateProduct(EditProductViewModel EditProduct);



    }
}
