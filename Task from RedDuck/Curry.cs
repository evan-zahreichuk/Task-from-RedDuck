using System;
using System.Linq;

namespace InterviewTasks
{
    public static class CurryHelper
    {
        public static dynamic Curry(Delegate f, params dynamic[] args)
        {
            if (args.Length >= f.Method.GetParameters().Length)
            {
                return f.DynamicInvoke(args);
            }
            return new Func<dynamic, dynamic>(arg => Curry(f, args.Concat(new dynamic[] { arg }).ToArray()));
        }
    }
}
