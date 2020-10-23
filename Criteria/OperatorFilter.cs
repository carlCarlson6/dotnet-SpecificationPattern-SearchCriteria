using System;

namespace Criteria
{
    public class OperatorFilter
    {
        public static String Equal { get=> "="; }
        public static String NotEqual { get=> "!="; }
        public static String GreaterEqual { get=> ">="; }
        public static String LesserEqual { get=> "<="; }
        public static String GreaterThan { get=> ">"; }
        public static String LesserThan { get=> "<"; }
    }
}