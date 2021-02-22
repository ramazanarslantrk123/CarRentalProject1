using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessDataResult<TEntity>:DataResult<TEntity>
    {
        public SuccessDataResult(string message,TEntity data):base(true,message,data)
        {

        }
        public SuccessDataResult(TEntity data):base(true,data)
        {

        }
        public SuccessDataResult(string message):base(true,message,default)
        {

        }
        public SuccessDataResult():base(true,default)
        {
                
        }
    }
}
