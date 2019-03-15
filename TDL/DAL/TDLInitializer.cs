using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDL.DAL
{
    public class TDLInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<TDLContext>
    {
        protected override void Seed(TDLContext context)
        {

            //base.Seed(context);
        }
    }
}