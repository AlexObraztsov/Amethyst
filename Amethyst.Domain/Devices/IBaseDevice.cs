using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amethyst.Domain.Devices
{
    public interface IBaseDevice
    {
        Guid Id { get; set; }
    }
}
