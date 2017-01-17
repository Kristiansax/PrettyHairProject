using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.KeyGenerators;

namespace PrettyHair.Core.Interfaces
{
    public interface IKeyGenerator
    {
        int NextKey { get; }
    }
}
