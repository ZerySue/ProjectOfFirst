using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo1.Model
{
    public class MainModel
    {

        public double input1
        { 
            get;
            set;
        }

        public double input2 { get; set; }

        public double resualt { get; set; }

        

        //public class DataItem
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //}
        //public static class DataDemo
        //{
        //    private static Collection<DataItem> _DataList = null;
        //    public static Collection<DataItem> DataList
        //    {
        //        get
        //        {
        //            if (_DataList == null)
        //            {
        //                _DataList = InitDataList();
        //            }
        //            return _DataList;
        //        }
        //    }
        //}
        //private static Collection<DataItem> InitDataList()
        //{
        //    Collection<DataItem> lists = new Collection<DataItem>();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        DataItem item = new DataItem();
        //        item.ID = i + 1;
        //        item.Name = "例子" + (i + 1);
        //        lists.Add(item);
        //    }
        //    return lists;
        //}
    }
    
}
