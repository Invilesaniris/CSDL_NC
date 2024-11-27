using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using Db4objects.Db4o.Ext;
using 

namespace FeedData
{
    static class GlobalDb4oAcces
    {
        static private string fileLocation = "\\bin\\Debug\\net8.0-windows\\DB4O_DEMO.db4o";
        static private IObjectContainer db4o = Db4oFactory.OpenFile(fileLocation);

        //static public IObjectContainer Database{
        //    get {
        //        if (db4o.Ext().IsClosed())
        //        {
        //            db4o = Db4oFactory.OpenFile(fileLocation);
        //        }
        //        return db4o;
        //    }
        //    private set { }
        //}

        static IList<T> DelegateSQL<T>(Func<T> sqlQuery)
        {
            IList<T> resultList = db4o.Query(delegate ());
        } 


    }
}
