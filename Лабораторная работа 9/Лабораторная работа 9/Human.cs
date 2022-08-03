using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Human: IVisitor, ICanDisinfectHand, ICanHaveQRCode, ICanPutOnMask
    {
        public string Name { get; set; }
        public bool IsHaveQR { get; set; }
        public bool IsHaveDisinfect { get; set; }
        public bool IsHaveMask { get; set; }

    }
}
