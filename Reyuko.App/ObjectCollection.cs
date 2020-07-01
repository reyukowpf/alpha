using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reyuko.App
{
    public class ObjectCollection : Collection<object>

    {

        public ObjectCollection()

        {

        }
   
        public ObjectCollection(IEnumerable collection)

        {


            foreach (object obj in collection)

            {

                Add(obj);

            }

        }


    }
}
