using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Constants
{
    public static class Timeout
    {
        public static TimeSpan DefaultElementWaitTimeout = TimeSpan.FromMinutes(1);
        public static class Seconds
        {

            public static TimeSpan OneHundred = TimeSpan.FromSeconds(100);

            public static TimeSpan Ten = TimeSpan.FromSeconds(10);

            public static TimeSpan Two = TimeSpan.FromSeconds(2);

            public static TimeSpan Five = TimeSpan.FromSeconds(5);
        }

        public static class Min
        {

            public static TimeSpan Ten = TimeSpan.FromMinutes(10);

            public static TimeSpan Two = TimeSpan.FromMinutes(2);

            public static TimeSpan Five = TimeSpan.FromMinutes(5);
        }
    }
}
