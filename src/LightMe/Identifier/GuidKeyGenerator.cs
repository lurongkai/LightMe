using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightMe.Identifier
{
    public class GuidKeyGenerator : KeyGenerator
    {
        public override string GenerateNewKey() {
            return Guid.NewGuid().ToString();
        }
    }
}
