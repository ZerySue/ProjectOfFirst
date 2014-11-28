using MVVMDemo1.Command;
using MVVMDemo1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MVVMDemo1.ViewModel
{
     class QueryDataViewModel : NotifycationObject
    {
        //#region
        ///// <summary>
        ///// 查询的数据
        ///// </summary>
        //private Collection<MVVMDemo1.Model.MainModel.DataItem> _dateList = null;
        ///// <summary>
        ///// 查询命令
        ///// </summary>
        //private ICommand _queryCommand = null;
        ///// <summary>
        ///// 搜索关键字
        ///// </summary>
        //private string _searchText = string.Empty;
        ///// <summary>
        ///// 搜索结果
        ///// </summary>
        //private string _searchResult = string.Empty;
        //#endregion
        //#region INotifyPropertyChanged 成员
        //public event PropertyChangedEventHandler PropertyChanged;
        //#endregion
        ///// <summary>
        ///// 搜索关键字
        ///// </summary>
        //public string SearchText
        //{
        //    get { return _searchText; }
        //    set
        //    {
        //        _searchText = value;
        //        if (PropertyChanged != null)
        //            this.PropertyChanged(this, new PropertyChangedEventArgs("SearchText"));
        //    }
        //}
        ///// <summary>
        ///// 搜索结果
        ///// </summary>
        //public string SearchResult
        //{
        //    get { return _searchResult; }
        //    set
        //    {
        //        _searchResult = value;
        //        if (PropertyChanged != null)
        //            PropertyChanged(this, new PropertyChangedEventArgs("SearchResult"));
        //    }
        //}
        ///// <summary>
        ///// 查询命令
        ///// </summary>
        //public ICommand QueryCommand
        //{
        //    get { return _queryCommand; }
        //}
        //public QueryDataViewModel(Collection<MVVMDemo1.Model.MainModel.DataItem> dataList)
        //{

        //    _dateList = dataList;
        //    _queryCommand = new QueryDataCommand(this);
        //}

        //public void QueryData()
        //{
        //    if (!string.IsNullOrEmpty(SearchResult))
        //    {
        //        MVVMDemo1.Model.MainModel.DataItem dataItem = null;
        //        foreach (MVVMDemo1.Model.MainModel.DataItem item in _dateList)
        //        {
        //            if (item.ID.ToString() == SearchText)
        //            {
        //                dataItem = item;
        //                break;
        //            }
        //        }
        //        if (dataItem != null)
        //            this.SearchResult = string.Format("ID:{0}\n Name:{1}", dataItem.ID, dataItem.Name);

        //    }
        //}

        private MainModel model1;

        public MainModel Pmodel1
        {
            get { return model1; }
            set
            {
                model1 = value;
                RasiePropertyChanged("Pmodel1");
            }
        }

        public QueryDataCommand AddCommand { get; set; }

        private MainModel mmodel;

        public void Add(object para)
        {

            Pmodel1.resualt = Pmodel1.input1 + Pmodel1.input2;

            mmodel = Pmodel1;

            Pmodel1 = mmodel;
         
        }

        public QueryDataViewModel()
        {
            Pmodel1 = new MainModel();

            AddCommand = new QueryDataCommand();
            AddCommand.ExecuteAction = new Action<object>(Add);
        }

    }
   }
