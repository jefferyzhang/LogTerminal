using System.Collections.Generic;
using System.Linq;

namespace LogTerminal
{
    /// <summary>
    /// 分页工具
    /// </summary>
    public class Pager
    {
        public int PageIndex { set; get; } = 1;
        public int PageSize { set; get; } = 10;

        public int TotalPageCount { set; get; }

        public void Reset(int totalItemCount)
        {
            PageIndex = 1;
            TotalPageCount = (totalItemCount + PageSize - 1) / PageSize;
        }

        public IList<T> GetPagedItems<T>(IList<T> totalItems)
        {
            return totalItems.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        }

        public void NextPage()
        {
            if (PageIndex < TotalPageCount)
            {
                PageIndex++;
            }
        }

        public void PrePage()
        {
            if (PageIndex > 1)
            {
                PageIndex--;
            }
        }
    }
}
