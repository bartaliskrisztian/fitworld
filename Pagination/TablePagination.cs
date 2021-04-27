using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Pagination
{
    public class TablePagination
    {
        public int PageNumber { get; set; } = 1;
        const int maxPageSize = 50;
        private int _pageSize = 5;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }

        public List<T> firstPage<T>(List<T> source)
        {
            return source.Take(PageSize + 1).ToList();
        }

        public List<T> nextPage<T>(List<T> source, int page)
        {
            return source.Skip(PageSize*(page - 1)).Take(PageSize).ToList();
        }
        public List<T> previousPage<T>(List<T> source, int page)
        {
            return source.Skip(PageSize * (page - 1)).Take(PageSize).ToList();
        }
        public List<T> lastPage<T>(List<T> source)
        {
            return source.Skip(Math.Max(0, source.Count) - PageSize).ToList();
        }
    } 

}
