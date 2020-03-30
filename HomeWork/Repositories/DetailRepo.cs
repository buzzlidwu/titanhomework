using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWork.Models;

namespace HomeWork.Repositories
{
    public class DetailRepo : IDetailRepo
    {

        public List<Detail> GetAllDetail()
        {
            var rand = new Random();
            var today = DateTime.Now;
            var detailLists = new List<Detail>();
            for (var i = 1; i <= 50; i++)
            {
                detailLists.Add(new Detail
                {
                    Id       = i,
                    Type     = rand .Next(0, 2) == 0 ? "收入" : "支出",
                    DateTime = today.AddDays(i).ToString("yyyy-MM-dd"),
                    Cost     = rand .Next(10,10000)
                });
            }

            return detailLists;
        }
    }
}