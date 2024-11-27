using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB4O_Demo.Ultilities
{
    static class GlobalDb4oAccess
    {
        static private string fileLocation = "..\\..\\..\\..\\db4o files\\DB4O_DEMO.db4o";
        static private IObjectContainer databaseFile= Db4oFactory.OpenFile(fileLocation);

        static public IObjectContainer Database { 
            get {
                if (databaseFile.Ext().IsClosed())
                    databaseFile = Db4oFactory.OpenFile("DB4O_DEMO.db4o");
                return databaseFile; 
            } 
        }


    }
}
