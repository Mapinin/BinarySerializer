﻿namespace BinarySerialization.Test.Endianness
{
    public class DeferredEndiannessEvaluationClass
    {
        [FieldOrder(0)]
        [FieldEndianness("Endianness", typeof(EndiannessConverter))]
        public ushort Value { get; set; }
        
        [FieldOrder(1)]
        public uint Endianness { get; set; }

    }
}
