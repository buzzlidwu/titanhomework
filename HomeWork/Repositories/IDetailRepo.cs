using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWork.Models;

namespace HomeWork.Repositories
{
    public interface IDetailRepo
    {
         List<Detail> GetAllDetail();
    }
}