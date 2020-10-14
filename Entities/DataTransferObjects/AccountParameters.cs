using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class AccountParameters:QueryStringParameters
    {
        public AccountParameters()
        {
            OrderBy = "DateCreated";
        }
    }
}
