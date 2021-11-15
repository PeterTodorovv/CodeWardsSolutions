using System;
using System.Collections.Generic;
using System.Text;

namespace PaginationHelper
{
    public class PaginationHelper<T>
    {
        // TODO: Complete this class

        IList<T> collection;
        int itemsPerPage;
        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            this.collection = collection;
            this.itemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return collection.Count / itemsPerPage;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex > PageCount)
                return -1;
            if(pageIndex == PageCount)
            {
                return collection.Count % itemsPerPage;
            }

            return itemsPerPage;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            int page = itemIndex / itemsPerPage;
            if (page <= PageCount) return page;

            return -1;
        }
    }
}
