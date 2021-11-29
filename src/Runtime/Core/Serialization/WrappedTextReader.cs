﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microsoft.ML.Probabilistic.Serialization
{
    public class WrappedTextReader : IReader, IDisposable
    {
        StreamReader reader;

        public WrappedTextReader(StreamReader streamReader)
        {
            this.reader = streamReader;
        }

        public void Dispose()
        {
            reader.Dispose();
        }

        public bool ReadBoolean()
        {
            string line = reader.ReadLine();
            return bool.Parse(line);
        }

        public double ReadDouble()
        {
            string line = reader.ReadLine();
            return double.Parse(line);
        }

        public Guid ReadGuid()
        {
            string line = reader.ReadLine();
            return Guid.Parse(line);
        }

        public int ReadInt32()
        {
            string line = reader.ReadLine();
            return int.Parse(line);
        }

        public object ReadObject()
        {
            string line = reader.ReadLine();
            return line;
        }

        public string ReadString()
        {
            return reader.ReadLine();
        }
    }
}
