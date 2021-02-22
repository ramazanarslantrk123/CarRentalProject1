using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class DataResult<TEntity> : Result, IDataResult<TEntity>
    {
        public TEntity Data { get;  }
        public DataResult(bool success, string message,TEntity data):base(success,message)
        {
            Data = data;
        }
        public DataResult(bool success,TEntity data):base(success)
        {
           
        }
        
    }
}
