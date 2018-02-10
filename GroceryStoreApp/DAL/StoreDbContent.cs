﻿using GroceryStoreApp.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStoreApp.DAL
{
    public class StoreDbContent : IdentityDbContext<User>
    {
        public StoreDbContent() : base()
        {

        }

        public static StoreDbContent Create()
        {
            return new StoreDbContent();
        }
        

    }
}