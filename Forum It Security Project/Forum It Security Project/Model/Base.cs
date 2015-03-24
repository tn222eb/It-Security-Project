using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum_It_Security_Project.Model
{
    public class Base
    {
        private Dictionary<string, string> _errorValidation;


        protected Dictionary<string, string> errorValidation
        {
            get
            {
                return this._errorValidation ?? (this._errorValidation = new Dictionary<string, string>());
            }
        }
    }
}