using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartData.API;

namespace SimpleDataDemo
{
    [System.Composition.Export(typeof(SmartData.API.ISmartDataRoot))]
    [SmartDataRoot]
    public class SimpleDataDemo : SmartData.API.ISmartDataRoot
    {

        Type[] SmartData.API.ISmartDataRoot.GetIgnoredPropertiesOfTypes()
        {
            return new Type[] { };
        }
    }
}
