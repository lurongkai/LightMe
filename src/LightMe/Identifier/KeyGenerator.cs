using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightMe.Identifier
{
    public abstract class KeyGenerator : IKeyGenerator
    {
        private static KeyGenerator _defaultKeyGenerator;
        public abstract string GenerateNewKey();

        public KeyGenerator Default {
            get { return _defaultKeyGenerator ?? new GuidKeyGenerator(); }
            set { _defaultKeyGenerator = value; }
        }
    }
}
