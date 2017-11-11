using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
    public class Result
    {
        public bool IsSucceedded { get; set; }

        public Result()
        {
            IsSucceedded = false;
        }

    }


    public class Result<T> : Result
    {
        public T TransactionResult { get; set; }
    }
}
