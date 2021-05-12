using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operation
    {
        public string LeftSide { get; set; }

        public string RightSide { get; set; }

        public OperationType OperationType {get; set;}

        public Operation InnerOperation { get; set; }

        #region Constructor
        public Operation()
        {
            this.LeftSide = String.Empty;
            this.RightSide = String.Empty;
        }
        #endregion

    }
}
