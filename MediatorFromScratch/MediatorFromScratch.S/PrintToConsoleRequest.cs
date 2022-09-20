using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorFromScratch.S
{
    public class PrintToConsoleRequest : IRequest<bool>
    {
        public string Text { get; init; }
    }
}
