using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreMini
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFeatureCollections : IDictionary<Type, object> { 
        
    }
    public class FeatureCollection : Dictionary<Type,object>, IFeatureCollections{ }

}
