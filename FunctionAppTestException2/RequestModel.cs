using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionAppTestException2
{
    public enum TestEnum
    {
        Generic,
        MifFinancial
    }
    public class RequestModel
    {
        public TestEnum MyProp { get; set; }
    }
}
