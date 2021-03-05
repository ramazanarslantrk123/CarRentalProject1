using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<TEntity>:DataResult<TEntity>
    {
        public ErrorDataResult(string message,TEntity data):base(false,message,data)
        {

        }
        public ErrorDataResult(TEntity data):base(false,data)
        {

        }
        public ErrorDataResult(string message):base(false,message,default)
        {

        }
        public ErrorDataResult():base(false,default)
        {

        }
    }
}
