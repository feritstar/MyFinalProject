using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is added successfully!";
        public static string ProductNameInvalid = "Product name is invalid.";
        public static string MaintenanceTime = "System is at maintenance, Come back later!";
        public static string ProductListed = "Products are listed as desired.";
        public static string ProductCannotAdded = "Units in stock can not be bigger than 10!";
        public static string ProductNameAlreadyExists = "Product name already exists!.";
        public static string CategoryLimitExceeds = "Category limit exceeded!.";
    }
}
