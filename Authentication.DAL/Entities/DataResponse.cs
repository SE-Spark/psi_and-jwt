using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.DAL.Entities
{
    class DataResponse<TEntity>:Response where TEntity : class
    {
        public TEntity Data { get; set; }
    }
}
